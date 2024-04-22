using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared.Services;

namespace MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Services;

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
