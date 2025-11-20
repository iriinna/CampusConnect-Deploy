using CampusConnect.Application;
using CampusConnect.Infrastructure.Data;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CampusConnect.Domain.Services;
using CampusConnect.Api.Services;


var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      builder =>
                      {
                          builder.WithOrigins("http://localhost:3000", // Adresa React standard
                                              "https://localhost:3000",
                                              "http://localhost:5173", // Adresa Vite (dacă folosești)
                                              "https://localhost:7000") // Sau orice port folosește frontend-ul tău
                                 .AllowAnyHeader()
                                 .AllowAnyMethod();
                      });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddHttpContextAccessor(); // Asigură accesul la HttpContext
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();
const string CorsPolicy = "Frontends";

builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection(); 
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();
app.MapControllers();

app.Run();
