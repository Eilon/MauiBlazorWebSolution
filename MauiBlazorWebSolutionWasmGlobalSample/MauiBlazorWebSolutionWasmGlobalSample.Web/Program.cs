using MauiBlazorWebSolutionWasmGlobalSample.Web.Components;
using MauiBlazorWebSolutionWasmGlobalSample.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSample.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

// Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSample.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(MauiBlazorWebSolutionWasmGlobalSample.Shared._Imports).Assembly,
        typeof(MauiBlazorWebSolutionWasmGlobalSample.Web.Client._Imports).Assembly);

app.Run();
