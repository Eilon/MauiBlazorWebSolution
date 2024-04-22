using MauiBlazorWebSolutionServerGlobalSampleProgramMain.Web.Components;
using MauiBlazorWebSolutionServerGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionServerGlobalSampleProgramMain.Web.Services;

namespace MauiBlazorWebSolutionServerGlobalSampleProgramMain;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();

        // Add device-specific services used by the MauiBlazorWebSolutionServerGlobalSampleProgramMain.Shared project
        builder.Services.AddSingleton<IFormFactor, FormFactor>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddAdditionalAssemblies(typeof(MauiBlazorWebSolutionServerGlobalSampleProgramMain.Shared._Imports).Assembly);

        app.Run();
    }
}
