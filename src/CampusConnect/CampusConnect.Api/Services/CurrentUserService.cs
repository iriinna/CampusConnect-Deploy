using CampusConnect.Application.Features; // Asigură-te că ai referință la Application!
using CampusConnect.Domain.Services;
using System.Security.Claims;

namespace CampusConnect.Api.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        // IHttpContextAccessor este serviciul standard ASP.NET Core care oferă acces la contextul HTTP
        _httpContextAccessor = httpContextAccessor;
    }

    private ClaimsPrincipal CurrentUser => _httpContextAccessor.HttpContext?.User;

    // ----------------------------------------------------
    // 1. Obținerea ID-ului Utilizatorului
    // ----------------------------------------------------

    public int? GetCurrentUserId()
    {
        // Verifică dacă utilizatorul este autentificat
        if (CurrentUser == null || !CurrentUser.Identity.IsAuthenticated)
        {
            return null;
        }

        // Găsește revendicarea (claim) care conține ID-ul. 
        // Numele "sub" (Subject) sau "nameidentifier" (NameIdentifier) sunt comune.
        var idClaim = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);

        if (idClaim != null && int.TryParse(idClaim.Value, out int userId))
        {
            return userId;
        }

        return null;
    }

    // ----------------------------------------------------
    // 2. Verificare de Rol
    // ----------------------------------------------------

    public bool IsInRole(string roleName)
    {
        if (CurrentUser == null)
        {
            return false;
        }
        // Metoda standard ClaimsPrincipal.IsInRole verifică dacă utilizatorul are claim-ul de rol specificat
        return CurrentUser.IsInRole(roleName);
    }

    // ----------------------------------------------------
    // 3. Obținerea Rolului Curent (Dacă e nevoie)
    // ----------------------------------------------------

    public string GetCurrentUserRole()
    {
        // Întoarce primul rol găsit sau null
        var roleClaim = CurrentUser?.FindFirst(ClaimTypes.Role);
        return roleClaim?.Value;
    }
}