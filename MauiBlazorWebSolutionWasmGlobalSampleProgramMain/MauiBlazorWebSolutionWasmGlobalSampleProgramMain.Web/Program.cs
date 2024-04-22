using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Components;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Services;

namespace MauiBlazorWebSolutionWasmGlobalSampleProgramMain;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveWebAssemblyComponents();

        // Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(
                typeof(MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared._Imports).Assembly,
                typeof(MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Client._Imports).Assembly);

        app.Run();
    }
}
