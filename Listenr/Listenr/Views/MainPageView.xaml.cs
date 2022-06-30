using Listenr.ViewModels;

namespace Listenr;

public partial class MainPageView : ContentPage
{
    public MainPageView(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

