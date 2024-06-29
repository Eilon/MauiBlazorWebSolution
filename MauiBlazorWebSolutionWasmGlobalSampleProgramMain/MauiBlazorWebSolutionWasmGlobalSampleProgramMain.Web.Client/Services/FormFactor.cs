using MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Shared.Services;

namespace MauiBlazorWebSolutionWasmGlobalSampleProgramMain.Web.Client.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "WebAssembly";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
