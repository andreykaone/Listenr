using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listenr.ViewModels
{
    [QueryProperty("Path", "path")]
    public partial class YoutubeLinkViewModel : ObservableObject
    {
        [ObservableProperty]
        string path;
    }
}
