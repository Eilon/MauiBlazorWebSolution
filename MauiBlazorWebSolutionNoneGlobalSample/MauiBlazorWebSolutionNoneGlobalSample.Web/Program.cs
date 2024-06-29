using MauiBlazorWebSolutionNoneGlobalSample.Web.Components;
using MauiBlazorWebSolutionNoneGlobalSample.Shared.Services;
using MauiBlazorWebSolutionNoneGlobalSample.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

// Add device-specific services used by the MauiBlazorWebSolutionNoneGlobalSample.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddAdditionalAssemblies(typeof(MauiBlazorWebSolutionNoneGlobalSample.Shared._Imports).Assembly);

app.Run();
