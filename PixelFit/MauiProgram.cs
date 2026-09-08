using Microsoft.Extensions.Logging;
using PixelFit.Service;
using System.Globalization;

namespace PixelFit
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Opretter MAUI-applikationen
            var builder = MauiApp.CreateBuilder();

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.InvariantCulture;

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    // Registrerer skrifttypen som bruges i appen
                    fonts.AddFont(
                        "OpenSans-Regular.ttf",
                        "OpenSansRegular"
                    );
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddScoped(sp =>
                new HttpClient
                {
                    BaseAddress = new Uri(
                        "https://pixelwebsiteapi.duckdns.org/"
                    )
                });

            // Registrerer AuthService så den kan bruges
            // i vores Razor-sider via Dependency Injection
            builder.Services.AddScoped<AuthService>();

            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();

            // Bygger og starter MAUI-applikationen
            return builder.Build();
        }
    }
}