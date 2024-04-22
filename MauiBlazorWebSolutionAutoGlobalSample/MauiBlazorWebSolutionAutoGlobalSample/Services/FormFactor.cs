using MauiBlazorWebSolutionAutoGlobalSample.Shared.Services;

namespace MauiBlazorWebSolutionAutoGlobalSample.Services;

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
