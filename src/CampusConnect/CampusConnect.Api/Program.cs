var builder = WebApplication.CreateBuilder(args);

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
