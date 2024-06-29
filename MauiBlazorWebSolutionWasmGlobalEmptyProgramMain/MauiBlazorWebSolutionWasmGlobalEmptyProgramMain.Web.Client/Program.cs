using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MauiBlazorWebSolutionWasmGlobalEmptyProgramMain.Web.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        await builder.Build().RunAsync();
    }
}
