using Avalonia.Media.Imaging;
using StrategyGameSketch.Models;

namespace StrategyGameSketch.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private Map _map=new();

    public Bitmap MapBitmap
    {
        get
        {
            var pngStream = _map.AsPngImage(); 
            return new Bitmap(pngStream);
        }
    }
}