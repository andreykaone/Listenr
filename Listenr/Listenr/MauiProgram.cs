using Listenr.ViewModels;

namespace Listenr;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
			});

		//Views
		builder.Services.AddSingleton<MainPageView>();

		//ViewModels
		builder.Services.AddSingleton<MainPageViewModel>();

		return builder.Build();
	}
}
