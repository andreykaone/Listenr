using Listenr.ViewModels;
using Listenr.Views;

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
		builder.Services.AddSingleton<YoutubeLinkView>();

        //ViewModels
        builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<YoutubeLinkViewModel>();

        return builder.Build();
	}
}
