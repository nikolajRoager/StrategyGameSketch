using System.IO;
using SkiaSharp;

namespace StrategyGameSketch.Models;

public class Map
{
    public int Width { get; }
    public int Height { get; }
    public Map()
    {
        Width = 250;
        Height = 180;
    }

    /// <summary>
    /// C
    /// </summary>
    /// <returns></returns>
    public MemoryStream AsPngImage()
    {
        
        var image = new SKImageInfo(Width,Height);
        using var bitmap = new SKBitmap(image);
        using (var canvas = new SKCanvas(bitmap))
        {
            canvas.Clear(SKColors. Purple);
        }

        var imageStream = new MemoryStream();
        bitmap.Encode(imageStream, SKEncodedImageFormat.Png, 50);
        imageStream.Position = 0;
        
        return imageStream;
    }
}