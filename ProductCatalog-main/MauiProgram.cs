using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductCatalog.Helpers;
using ProductCatalog.Models;

namespace ProductCatalog
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Ruta a la base de datos SQLite
            var dbPath = FileHelper.GetLocalFilePath("");

            // Registrar el DbContext
            builder.Services.AddDbContext<DataContext>(options =>
                options.UseSqlite($"Data Source={dbPath}"));

            var app = builder.Build();

            // Asegurarse que la BD esté creada al iniciar la app
            using var scope = app.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
            dbContext.Database.EnsureCreated();

            return app;
        }
    }
}
