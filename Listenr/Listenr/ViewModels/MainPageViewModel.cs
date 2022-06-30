using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Listenr.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listenr.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        public MainPageViewModel()
        {
            Title = "Первая страница";
        }

        [RelayCommand]
        static async Task GoToYoutubeLinkViewAsync()
        {
            await Shell.Current.GoToAsync(nameof(YoutubeLinkView));
        }
    }
}
