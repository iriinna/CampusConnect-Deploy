using CampusConnect.Api.Services;
using CampusConnect.Application;
using CampusConnect.Domain.Services;
using CampusConnect.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.OpenApi.Models; // <- NOU: Necesar pentru configurarea Swagger

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

const string CorsPolicy = "Frontends";
builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, policy =>
        policy.WithOrigins(
                "http://localhost:5173") // Asigurați-vă că acesta este portul React/Vite
            .AllowAnyHeader()
            .AllowAnyMethod()
            );
});


// 1. Configurarea Serviciilor
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<ICurrentUserService, CurrentUserService>();

// Configurarea implicită a MediatR din proiectul Application (presupunând că ați adăugat-o acolo)
// builder.Services.AddApplicationServices(); 

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// Configurarea SwaggerGen CORECTĂ pentru a preveni Eroarea 500
builder.Services.AddSwaggerGen(options =>
{
    // Adăugăm detalii minime pentru Swagger UI
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CampusConnect API",
        Version = "v1"
    });

    // Această linie previne erorile 500 când există clase cu nume identice
    // în namespace-uri diferite (comun în proiectele Clean Architecture/CQRS).
    options.CustomSchemaIds(type => type.FullName);

    // ATENȚIE: Am eliminat sau comentat logica IncludeXmlComments. 
    // Dacă doriți documentație XML, trebuie să vă asigurați că fișierul XML este generat
    // și calea este corectă. Fără această logică, interfața ar trebui să se încarce.
});


// 2. Construirea Aplicației
var app = builder.Build();

// 3. Configurarea Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Va fi accesibil la http://localhost:5099/swagger
}

app.UseHttpsRedirection();
app.UseCors(CorsPolicy);
app.UseAuthorization();
app.MapControllers();

app.Run();