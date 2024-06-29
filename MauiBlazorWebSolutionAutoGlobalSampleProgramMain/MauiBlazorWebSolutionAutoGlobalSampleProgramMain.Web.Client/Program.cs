using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiBlazorWebSolutionAutoGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionAutoGlobalSampleProgramMain.Web.Client.Services;

namespace MauiBlazorWebSolutionAutoGlobalSampleProgramMain.Web.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        // Add device-specific services used by the MauiBlazorWebSolutionAutoGlobalSampleProgramMain.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        await builder.Build().RunAsync();
    }
}
