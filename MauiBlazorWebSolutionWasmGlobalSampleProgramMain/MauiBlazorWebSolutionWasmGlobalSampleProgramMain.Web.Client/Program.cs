using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Client.Services;

namespace MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        // Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        await builder.Build().RunAsync();
    }
}
