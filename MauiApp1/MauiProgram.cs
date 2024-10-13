using Microsoft.Maui.Controls.Handlers;
using Microsoft.Extensions.Logging;

namespace MauiApp1
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
            builder.ConfigureMauiHandlers(handlers =>
            {
#if ANDROID
                handlers.AddHandler(typeof(Shell), typeof(MauiApp1.Platforms.Android.CustomShellHandler));
#elif IOS
                handlers.AddHandler(typeof(Shell), typeof(MauiApp1.Platforms.iOS.CustomShellHandler));
#endif
            });
            return builder.Build();
        }
    }
}
