using MauiBlazorWebSolutionWasmGlobalSample.Shared.Services;

namespace MauiBlazorWebSolutionWasmGlobalSample.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return DeviceInfo.Idiom.ToString();
    }

    public string GetPlatform()
    {
        return DeviceInfo.Platform.ToString() + " - " + DeviceInfo.VersionString;
    }
}
