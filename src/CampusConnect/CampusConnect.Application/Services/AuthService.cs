using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CampusConnect.Application.DTOs.Auth;
using CampusConnect.Application.Interfaces;
using CampusConnect.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CampusConnect.Application.Services;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IEmailService _emailService;
    private readonly IConfiguration _configuration;
    private readonly string[] _allowedDomains;

    public AuthService(
        UserManager<ApplicationUser> userManager,
        IEmailService emailService,
        IConfiguration configuration)
    {
        _userManager = userManager;
        _emailService = emailService;
        _configuration = configuration;
        _allowedDomains = configuration.GetSection("AllowedEmailDomains").Get<string[]>() 
            ?? new[] { "@unibuc.ro", "@s.unibuc.ro" };
    }

    public async Task<AuthResult> RegisterAsync(RegisterRequest request)
    {
        // Validare domeniu email
        if (!IsEmailDomainAllowed(request.Email))
        {
            return new AuthResult
            {
                Success = false,
                Message = "Doar studenții UniBuc pot crea cont (email trebuie să fie @unibuc.ro sau @s.unibuc.ro)"
            };
        }

        // Verificare dacă emailul există deja
        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser != null)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Un cont cu acest email există deja"
            };
        }

        // Creare user
        var user = new ApplicationUser
        {
            UserName = request.Email,
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            StudentId = request.StudentId,
            DateOfBirth = request.DateOfBirth,
            CreatedAt = DateTime.UtcNow
        };

        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Eroare la crearea contului",
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }

        // 1. Normalizarea și determinarea rolului
    var normalizedEmail = request.Email.ToLowerInvariant();
    string role;
    
    // Admin pentru adresele @unibuc.ro
    if (normalizedEmail.EndsWith("@unibuc.ro"))
    {
        role = "Admin";
    }
    // User pentru adresele @s.unibuc.ro
    else if (normalizedEmail.EndsWith("@s.unibuc.ro"))
    {
        role = "User";
    }
    else
    {
        // Caz de rezervă, deși ar trebui să fie prins de IsEmailDomainAllowed
        role = "User"; 
    }

    // 2. Atribuirea rolului
    var roleResult = await _userManager.AddToRoleAsync(user, role);

    if (!roleResult.Succeeded)
    {
        // Dacă atribuirea rolului eșuează (ex: rolul nu există),
        // este crucial să ștergi userul proaspăt creat pentru a evita 
        // conturi orfane sau nefuncționale.
        await _userManager.DeleteAsync(user); 
        
        return new AuthResult
        {
            Success = false,
            Message = $"Contul a fost creat, dar atribuirea rolului '{role}' a eșuat. S-a anulat crearea contului.",
            Errors = roleResult.Errors.Select(e => e.Description).ToList()
        };
    }
        // Generare token de confirmare email
        var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        
        // Encode token pentru URL
        var encodedToken = Uri.EscapeDataString(emailToken);
        var confirmationLink = $"{_configuration["AppSettings:FrontendUrl"]}/confirm-email?userId={user.Id}&token={encodedToken}";

        // Trimite email de confirmare
        await _emailService.SendEmailConfirmationAsync(user.Email, confirmationLink);

        return new AuthResult
        {
            Success = true,
            Message = "Cont creat cu succes! Verifică-ți emailul pentru confirmare."
        };
    }

    public async Task<AuthResult> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Email sau parolă incorectă"
            };
        }

        // Verificare email confirmat
        if (!user.EmailConfirmed)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Trebuie să confirmi emailul înainte de a te autentifica. Verifică inbox-ul."
            };
        }

        // Verificare parolă
        var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!isPasswordValid)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Email sau parolă incorectă"
            };
        }

        // Update last login
        user.LastLoginAt = DateTime.UtcNow;
        await _userManager.UpdateAsync(user);

        // Generare JWT token
        var token = GenerateJwtToken(user);
        var expirationDays = int.Parse(_configuration["JwtSettings:ExpirationInDays"] ?? "7");

        return new AuthResult
        {
            Success = true,
            Message = "Autentificare reușită",
            Data = new LoginResponse
            {
                Token = token,
                Email = user.Email!,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserId = user.Id,
                ExpiresAt = DateTime.UtcNow.AddDays(expirationDays)
            }
        };
    }

    public async Task<AuthResult> ConfirmEmailAsync(int userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());

        if (user == null)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Utilizator invalid"
            };
        }

        if (user.EmailConfirmed)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Emailul este deja confirmat"
            };
        }

        // Decode token
        var decodedToken = Uri.UnescapeDataString(token);
        var result = await _userManager.ConfirmEmailAsync(user, decodedToken);

        if (!result.Succeeded)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Token invalid sau expirat",
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }

        return new AuthResult
        {
            Success = true,
            Message = "Email confirmat cu succes! Acum te poți autentifica."
        };
    }

    public async Task<AuthResult> ResendEmailConfirmationAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);

        if (user == null)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Nu există niciun cont cu acest email"
            };
        }

        if (user.EmailConfirmed)
        {
            return new AuthResult
            {
                Success = false,
                Message = "Emailul este deja confirmat"
            };
        }

        // Generare token nou
        var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var encodedToken = Uri.EscapeDataString(emailToken);
        var confirmationLink = $"{_configuration["AppSettings:FrontendUrl"]}/confirm-email?userId={user.Id}&token={encodedToken}";

        await _emailService.SendEmailConfirmationAsync(user.Email!, confirmationLink);

        return new AuthResult
        {
            Success = true,
            Message = "Email de confirmare retrimis. Verifică inbox-ul."
        };
    }

    private bool IsEmailDomainAllowed(string email)
    {
        return _allowedDomains.Any(domain => email.EndsWith(domain, StringComparison.OrdinalIgnoreCase));
    }

    private string GenerateJwtToken(ApplicationUser user)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email!),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var expirationDays = int.Parse(_configuration["JwtSettings:ExpirationInDays"] ?? "7");

        var token = new JwtSecurityToken(
            issuer: _configuration["JwtSettings:Issuer"],
            audience: _configuration["JwtSettings:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddDays(expirationDays),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
