using Microsoft.Extensions.Logging;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Services;

namespace MauiBlazorWebSolutionWasmGlobalSampleProgramMain;

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
            });

        // Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
