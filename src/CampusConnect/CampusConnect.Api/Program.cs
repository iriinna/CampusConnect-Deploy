using CampusConnect.Api.Services;
using CampusConnect.Application; // ⬅️ ACUM ESTE NECESAR PENTRU METODA EXTENSIE
using CampusConnect.Domain.Services;
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
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var key = Encoding.ASCII.GetBytes(builder.Configuration["Jwt:Key"]);

const string CorsPolicy = "Frontends";
builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
        policy.WithOrigins(
                "http://localhost:5173") 
            .AllowAnyHeader()
            .AllowAnyMethod()
            );
});

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
app.UseCors(CorsPolicy);
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();


// Local extension to provide AddInfrastructureServices if it's missing in other assemblies.
// Register real infrastructure services here or keep as no-op to satisfy the call.
public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // TODO: Register repositories, integration services, etc.
        return services;
    }
}