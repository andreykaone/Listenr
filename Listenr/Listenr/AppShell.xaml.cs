using Listenr.Views;

namespace Listenr;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(YoutubeLinkView), typeof(YoutubeLinkView));
	}
}
