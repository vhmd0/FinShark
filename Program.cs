using finshark.Interfaces;
using finshark.Model;
using finshark.Repositorys;
using finshark.Services;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var connectionString = builder.Configuration.GetConnectionString("NeonConnection") ?? throw new InvalidOperationException("Connection string 'NeonConnection' not found.");

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString, o => o.CommandTimeout(60)));

        builder.Services.AddScoped<IStockRepository, StockRepository>();
        builder.Services.AddScoped<IStockService, StockService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options => options
                .WithTitle("Finshark API Documentation")
                .WithTheme(ScalarTheme.Saturn)
                .WithDarkMode());
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}