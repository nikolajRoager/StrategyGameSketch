using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace StrategyGameSketch.Models;

public class Province
{
    /// <summary>
    /// X Location of the province center in the image panel
    /// </summary>
    public int X {get; set;}
    /// <summary>
    /// Y Location of the province center in the image panel
    /// </summary>
    public int Y {get; set;}
    /// <summary>
    /// Name and key of this province
    /// </summary>
    public string Name { get; set; } = "null";
    
    /// <summary>
    /// The other province names near this thing
    /// </summary>
    public List<string> NeighbourNames = new();
    
    /// <summary>
    /// De-jure owner
    /// </summary>
    public string Owner { get; set; } = "Ukraine";

    /// <summary>
    /// De-facto controller
    /// </summary>
    public string Controller { get; set; } = "Ukraine";
    
    
}