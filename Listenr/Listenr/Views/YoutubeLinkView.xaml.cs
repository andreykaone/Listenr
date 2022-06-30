using Listenr.ViewModels;

namespace Listenr.Views;

public partial class YoutubeLinkView : ContentPage
{
	public YoutubeLinkView(YoutubeLinkViewModel viewmodel)
	{
		InitializeComponent();
		BindingContext = viewmodel;

    }
}