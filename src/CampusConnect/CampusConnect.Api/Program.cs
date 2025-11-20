using CampusConnect.Application;
using CampusConnect.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CampusConnect.Domain.Services;
using CampusConnect.Api.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddHttpContextAccessor(); // Asigură accesul la HttpContext
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
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

builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors(CorsPolicy);  
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();
