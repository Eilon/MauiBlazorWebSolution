using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiBlazorWebSolutionWasmGlobalSample.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSample.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSample.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
