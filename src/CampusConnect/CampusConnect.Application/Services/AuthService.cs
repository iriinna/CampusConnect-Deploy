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
<<<<<<< HEAD
    private readonly RoleManager<IdentityRole<int>> _roleManager; // Adăugat pentru gestionarea rolurilor
=======
>>>>>>> main
    private readonly IEmailService _emailService;
    private readonly IConfiguration _configuration;
    private readonly string[] _allowedDomains;

    public AuthService(
        UserManager<ApplicationUser> userManager,
<<<<<<< HEAD
        RoleManager<IdentityRole<int>> roleManager, // Injectăm RoleManager
=======
>>>>>>> main
        IEmailService emailService,
        IConfiguration configuration)
    {
        _userManager = userManager;
<<<<<<< HEAD
        _roleManager = roleManager;
=======
>>>>>>> main
        _emailService = emailService;
        _configuration = configuration;
        _allowedDomains = configuration.GetSection("AllowedEmailDomains").Get<string[]>() 
            ?? new[] { "@unibuc.ro", "@s.unibuc.ro" };
    }

    public async Task<AuthResult> RegisterAsync(RegisterRequest request)
    {
<<<<<<< HEAD
        // 1. Validare domeniu email
=======
        // Validare domeniu email
>>>>>>> main
        if (!IsEmailDomainAllowed(request.Email))
        {
            return new AuthResult
            {
                Success = false,
<<<<<<< HEAD
                Message = "Doar studenții sau angajații UniBuc pot crea cont (email-ul trebuie să fie @unibuc.ro sau @s.unibuc.ro)."
            };
        }

        // 2. Verificare dacă emailul există deja
=======
                Message = "Doar studenții UniBuc pot crea cont (email trebuie să fie @unibuc.ro sau @s.unibuc.ro)"
            };
        }

        // Verificare dacă emailul există deja
>>>>>>> main
        var existingUser = await _userManager.FindByEmailAsync(request.Email);
        if (existingUser != null)
        {
            return new AuthResult
            {
                Success = false,
<<<<<<< HEAD
                Message = "Un cont cu acest email există deja."
            };
        }

        // 3. Pregătire entitate User
=======
                Message = "Un cont cu acest email există deja"
            };
        }

        // Creare user
>>>>>>> main
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

<<<<<<< HEAD
        // 4. Creare utilizator în Identity (Verifică parola aici)
=======
>>>>>>> main
        var result = await _userManager.CreateAsync(user, request.Password);

        if (!result.Succeeded)
        {
            return new AuthResult
            {
                Success = false,
<<<<<<< HEAD
                Message = "Eroare la crearea contului. Verifică dacă parola respectă cerințele.",
                Errors = result.Errors.Select(e => e.Description).ToList() // Aici vei vedea erorile de complexitate parolă
            };
        }

        // 5. Atribuire Rol (Admin pentru @unibuc.ro, User pentru @s.unibuc.ro)
        var normalizedEmail = request.Email.ToLowerInvariant();
        string roleName = normalizedEmail.EndsWith("@unibuc.ro") ? "Admin" : "User";

        // Asigură-te că rolul există în bază înainte de a-l atribui
        if (!await _roleManager.RoleExistsAsync(roleName))
        {
            await _roleManager.CreateAsync(new IdentityRole<int>(roleName));
        }

        var roleResult = await _userManager.AddToRoleAsync(user, roleName);

        if (!roleResult.Succeeded)
        {
            // Dacă rolul eșuează, ștergem user-ul creat parțial pentru a nu lăsa date inconsistente
            await _userManager.DeleteAsync(user); 
            
            return new AuthResult
            {
                Success = false,
                Message = $"Eroare la atribuirea rolului '{roleName}'. Contul a fost anulat.",
                Errors = roleResult.Errors.Select(e => e.Description).ToList()
            };
        }

        // 6. Generare Token Confirmare Email
        var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var encodedToken = Uri.EscapeDataString(emailToken);
        var confirmationLink = $"{_configuration["AppSettings:FrontendUrl"]}/confirm-email?userId={user.Id}&token={encodedToken}";

        try 
        {
            await _emailService.SendEmailConfirmationAsync(user.Email, confirmationLink);
        }
        catch (Exception ex)
        {
            // Opțional: Logăm eroarea de email dar nu blocăm succesul contului
            Console.WriteLine($"Email Error: {ex.Message}");
        }
=======
                Message = "Eroare la crearea contului",
                Errors = result.Errors.Select(e => e.Description).ToList()
            };
        }

    var normalizedEmail = request.Email.ToLowerInvariant();
    string role;
    //Admin pentru adresele @unibuc.ro
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
        role = "User"; 
    }

    var roleResult = await _userManager.AddToRoleAsync(user, role);

    if (!roleResult.Succeeded)
    {
        await _userManager.DeleteAsync(user); 
        
        return new AuthResult
        {
            Success = false,
            Message = $"Contul a fost creat, dar atribuirea rolului '{role}' a esuat. S-a anulat crearea contului.",
            Errors = roleResult.Errors.Select(e => e.Description).ToList()
        };
    }
        var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        
        // Encode token pentru URL
        var encodedToken = Uri.EscapeDataString(emailToken);
        var confirmationLink = $"{_configuration["AppSettings:FrontendUrl"]}/confirm-email?userId={user.Id}&token={encodedToken}";

        // Trimite email de confirmare
        await _emailService.SendEmailConfirmationAsync(user.Email, confirmationLink);
>>>>>>> main

        return new AuthResult
        {
            Success = true,
<<<<<<< HEAD
            Message = "Cont creat cu succes! Te rugăm să îți verifici email-ul pentru confirmare."
=======
            Message = "Cont creat cu succes! Verifică-ti emailul pentru confirmare."
>>>>>>> main
        };
    }

    public async Task<AuthResult> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);

        if (user == null)
        {
<<<<<<< HEAD
            return new AuthResult { Success = false, Message = "Email sau parolă incorectă." };
        }

        if (!user.EmailConfirmed)
        {
            return new AuthResult { Success = false, Message = "Trebuie să confirmi email-ul înainte de autentificare." };
        }

        var isPasswordValid = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!isPasswordValid)
        {
            return new AuthResult { Success = false, Message = "Email sau parolă incorectă." };
        }

        user.LastLoginAt = DateTime.UtcNow;
        await _userManager.UpdateAsync(user);
        var roles = await _userManager.GetRolesAsync(user);
        var role = roles.FirstOrDefault() ?? "User";

        var token = GenerateJwtToken(user, role);
=======
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
>>>>>>> main
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
<<<<<<< HEAD
                ExpiresAt = DateTime.UtcNow.AddDays(expirationDays),
                Role = role
=======
                ExpiresAt = DateTime.UtcNow.AddDays(expirationDays)
>>>>>>> main
            }
        };
    }

    public async Task<AuthResult> ConfirmEmailAsync(int userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId.ToString());
<<<<<<< HEAD
        if (user == null) return new AuthResult { Success = false, Message = "Utilizator invalid." };
        if (user.EmailConfirmed) return new AuthResult { Success = false, Message = "Email deja confirmat." };

        var result = await _userManager.ConfirmEmailAsync(user, Uri.UnescapeDataString(token));
        if (!result.Succeeded)
        {
            return new AuthResult { Success = false, Message = "Token invalid sau expirat.", Errors = result.Errors.Select(e => e.Description).ToList() };
        }

        return new AuthResult { Success = true, Message = "Email confirmat cu succes!" };
=======

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
>>>>>>> main
    }

    public async Task<AuthResult> ResendEmailConfirmationAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
<<<<<<< HEAD
        if (user == null) return new AuthResult { Success = false, Message = "Cont inexistent." };
        if (user.EmailConfirmed) return new AuthResult { Success = false, Message = "Deja confirmat." };

        var emailToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        var confirmationLink = $"{_configuration["AppSettings:FrontendUrl"]}/confirm-email?userId={user.Id}&token={Uri.EscapeDataString(emailToken)}";
        await _emailService.SendEmailConfirmationAsync(user.Email!, confirmationLink);

        return new AuthResult { Success = true, Message = "Email de confirmare retrimis." };
=======

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
>>>>>>> main
    }

    private bool IsEmailDomainAllowed(string email)
    {
        return _allowedDomains.Any(domain => email.EndsWith(domain, StringComparison.OrdinalIgnoreCase));
    }

<<<<<<< HEAD
    private string GenerateJwtToken(ApplicationUser user, string role)
=======
    private string GenerateJwtToken(ApplicationUser user)
>>>>>>> main
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email!),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
<<<<<<< HEAD
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            new Claim(ClaimTypes.Role, role)
=======
            new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
>>>>>>> main
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
<<<<<<< HEAD
=======
        var expirationDays = int.Parse(_configuration["JwtSettings:ExpirationInDays"] ?? "7");

>>>>>>> main
        var token = new JwtSecurityToken(
            issuer: _configuration["JwtSettings:Issuer"],
            audience: _configuration["JwtSettings:Audience"],
            claims: claims,
<<<<<<< HEAD
            expires: DateTime.UtcNow.AddDays(7),
=======
            expires: DateTime.UtcNow.AddDays(expirationDays),
>>>>>>> main
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> main
