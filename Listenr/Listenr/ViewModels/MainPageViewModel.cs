using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using YoutubeExplode;

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
                var streamInfo = streamManifest.GetAudioOnlyStreams().OrderBy(x => x.Bitrate).FirstOrDefault();

                var uri = new Uri($"{streamInfo.Url}");
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
