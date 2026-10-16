using CincyGuard.Server.Models;
using Microsoft.EntityFrameworkCore;
using CincyGuard.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<CincyGuard.Server.Services.CrimeApiService>();
builder.Services.AddControllers();
builder.Services.AddDbContext<CrimeContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CrimeContext")));
builder.Services.AddScoped<CrimeDbSeeder>();


var app = builder.Build();

// seed the database with the crimes from the API
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var seeder =
        services.GetRequiredService<CrimeDbSeeder>();

    await seeder.SeedDb();
}

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
