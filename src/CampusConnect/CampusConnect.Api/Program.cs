<<<<<<< Updated upstream
﻿using CampusConnect.Api.Services;
using CampusConnect.Application; // ⬅️ ACUM ESTE NECESAR PENTRU METODA EXTENSIE
using CampusConnect.Domain.Services;
=======
﻿using System.Text;
using CampusConnect.Application.Interfaces;
using CampusConnect.Application.Services;
using CampusConnect.Domain.Entities;
>>>>>>> Stashed changes
using CampusConnect.Infrastructure.Data;
using CampusConnect.Infrastructure;
using CampusConnect.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models; 
using MediatR; // ⬅️ NECESAR PENTU DI MediatR
using CampusConnect.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
<<<<<<< Updated upstream
using System.Text;
=======
using System.Text.Json.Serialization;
>>>>>>> Stashed changes

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

// 1. Configurare CORS
const string CorsPolicy = "Frontends";
builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
<<<<<<< Updated upstream
        policy.WithOrigins(
                "http://localhost:5173") 
=======
        policy.WithOrigins("http://localhost:5173")
>>>>>>> Stashed changes
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials());
});

<<<<<<< Updated upstream
=======
// 2. Configurare Bază de Date (O singură dată, cu MigrationsAssembly)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        b => b.MigrationsAssembly("CampusConnect.Infrastructure")
    ));

// 3. Configurare Identity cu suport pentru Roluri
builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;

    options.SignIn.RequireConfirmedEmail = true;
    options.User.RequireUniqueEmail = true;
})
.AddRoles<IdentityRole<int>>() // IMPORTANT: Permite utilizarea RoleManager
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// 4. Configurare JWT
var jwtSection = builder.Configuration.GetSection("JwtSettings");
var jwtSecret = jwtSection["Secret"] ?? "CheieTemporaraDeSigurantaMinim32Caractere";
var jwtIssuer = jwtSection["Issuer"];
var jwtAudience = jwtSection["Audience"];

>>>>>>> Stashed changes
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false; // Set to true in production
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, // Setează la true și furnizează Issuer-ul în producție
        ValidateAudience = false, // Setează la true și furnizează Audience-ul în producție
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero // Elimină toleranța de expirare
    };
});
<<<<<<< Updated upstream
// 1. Configurarea Serviciilor
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

// 1. Înregistrează MediatR (din proiectul Application)
builder.Services.AddApplicationServices(); 

// 2. Înregistrează Repositoriile (direct, pentru a elimina orice eroare de apel extern)
// Aceasta rezolvă toate excepțiile de tip IUserRepository și IPostRepository
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IPostRepository, PostRepository>(); // register concrete repository directly to avoid missing/incompatible IPostRepository
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// Configurarea SwaggerGen CORECTĂ
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CampusConnect API",
        Version = "v1"
    });
    options.CustomSchemaIds(type => type.FullName);
});


// 2. Construirea Aplicației
var app = builder.Build();

// 3. Configurarea Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
=======

// 5. Înregistrare Servicii
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// --- LOGICA DE SEEDING PENTRU ROLURI ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole<int>>>();
        await SeedRolesAsync(roleManager);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "A apărut o eroare la crearea rolurilor.");
    }
}

// 6. Pipeline HTTP
>>>>>>> Stashed changes
app.UseCors(CorsPolicy);
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

<<<<<<< Updated upstream

// Local extension to provide AddInfrastructureServices if it's missing in other assemblies.
// Register real infrastructure services here or keep as no-op to satisfy the call.
public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
=======
// Metoda de Seed mutată în afara fluxului principal sau păstrată ca statică
async Task SeedRolesAsync(RoleManager<IdentityRole<int>> roleManager)
{
    string[] roleNames = { "Admin", "User" };
    foreach (var roleName in roleNames)
>>>>>>> Stashed changes
    {
        // TODO: Register repositories, integration services, etc.
        return services;
    }
}