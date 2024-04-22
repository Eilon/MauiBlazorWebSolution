using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MauiBlazorWebSolutionAutoGlobalSample.Shared.Services;
using MauiBlazorWebSolutionAutoGlobalSample.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MauiBlazorWebSolutionAutoGlobalSample.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
