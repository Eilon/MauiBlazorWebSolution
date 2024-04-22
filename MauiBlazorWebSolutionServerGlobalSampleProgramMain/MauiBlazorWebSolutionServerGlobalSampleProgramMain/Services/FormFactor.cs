using MauiBlazorWebSolutionServerGlobalSampleProgramMain.Shared.Services;

namespace MauiBlazorWebSolutionServerGlobalSampleProgramMain.Services;

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
