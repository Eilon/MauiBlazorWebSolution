using MauiBlazorWebSolutionNoneGlobalSampleProgramMain.Web.Components;
using MauiBlazorWebSolutionNoneGlobalSampleProgramMain.Shared.Services;
using MauiBlazorWebSolutionNoneGlobalSampleProgramMain.Web.Services;

namespace MauiBlazorWebSolutionNoneGlobalSampleProgramMain;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents();

        // Add device-specific services used by the MauiBlazorWebSolutionNoneGlobalSampleProgramMain.Shared project
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
            .AddAdditionalAssemblies(typeof(MauiBlazorWebSolutionNoneGlobalSampleProgramMain.Shared._Imports).Assembly);

        app.Run();
    }
}
