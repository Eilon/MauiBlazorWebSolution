using MauiBlazorWebSolutionWasmGlobalSample.Shared.Services;

namespace MauiBlazorWebSolutionWasmGlobalSample.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
