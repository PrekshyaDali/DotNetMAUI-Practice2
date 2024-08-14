using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;
using CommunityToolkit.Maui;
using Microsoft.Maui.LifecycleEvents;
namespace PrekshyaMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .UseSkiaSharp(true)
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
            private static MauiAppBuilder RegisterFirebaseServices(this MauiAppBuilder builder)
            {
                builder.ConfigureLifecycleEvents(events =>
                {
#if IOS
            events.AddiOS(iOS => iOS.FinishedLaunching((app, launchOptions) => {
                CrossFirebase.Initialize(CreateCrossFirebaseSettings());
                return false;
            }));
#else
                    events.AddAndroid(android => android.OnCreate((activity, _) =>
                        CrossFirebase.Initialize(activity, CreateCrossFirebaseSettings())));
                    CrossFirebaseCrashlytics.Current.SetCrashlyticsCollectionEnabled(true);
#endif
                });

                builder.Services.AddSingleton(_ => CrossFirebaseAuth.Current);
                return builder;
            }
            private static CrossFirebaseSettings CreateCrossFirebaseSettings()
            {
                return new CrossFirebaseSettings(isAuthEnabled: true,
                isCloudMessagingEnabled: true, isAnalyticsEnabled: true);
            }
        }
    }
}
