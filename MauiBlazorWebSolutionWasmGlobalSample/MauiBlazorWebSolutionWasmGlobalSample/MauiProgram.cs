﻿using Microsoft.Extensions.Logging;
using MauiBlazorWebSolutionWasmGlobalSample.Shared.Services;
using MauiBlazorWebSolutionWasmGlobalSample.Services;

namespace MauiBlazorWebSolutionWasmGlobalSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		// Add device-specific services used by the MauiBlazorWebSolutionWasmGlobalSample.Shared project
		builder.Services.AddSingleton<IFormFactor, FormFactor>();

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
