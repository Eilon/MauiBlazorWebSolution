using MauiBlazorWebSolutionServerGlobalSample.Shared.Services;

namespace MauiBlazorWebSolutionServerGlobalSample.Web.Services;

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
