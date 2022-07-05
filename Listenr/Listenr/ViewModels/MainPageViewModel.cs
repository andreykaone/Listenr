using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Listenr.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        string urlii;

        private YoutubeClient youtubeClient => new();

        [RelayCommand]
        async Task OpenBrowserAsync()
        {
            try
            {
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(Urlii);
                var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                var uri = new Uri($"{streamInfo.Url}");
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch
            {
                await Shell.Current.DisplayAlert("Oopsie!", "Looks like we have some problems, Houston!", "Relax");
            }
        }
    }
}
