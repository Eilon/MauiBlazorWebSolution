using MauiBlazorWebSolutionAutoGlobalSample.Shared.Services;

namespace MauiBlazorWebSolutionAutoGlobalSample.Web.Services;

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
