// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ComicsAppWasm.ComicsService.ComicSources.Xkcd.Models;

using Newtonsoft.Json;
using System.Linq;

public partial class Comic
{
    /// <summary>
    /// Initializes a new instance of the Comic class.
    /// </summary>
    public Comic()
    {
        CustomInit();
    }

    /// <summary>
    /// Initializes a new instance of the Comic class.
    /// </summary>
    public Comic(string alt = default(string), string day = default(string), string img = default(string), string link = default(string), string month = default(string), string news = default(string), double? num = default(double?), string safeTitle = default(string), string title = default(string), string transcript = default(string), string year = default(string))
    {
        Alt = alt;
        Day = day;
        Img = img;
        Link = link;
        Month = month;
        News = news;
        Num = num;
        SafeTitle = safeTitle;
        Title = title;
        Transcript = transcript;
        Year = year;
        CustomInit();
    }

    /// <summary>
    /// An initialization method that performs custom operations like setting defaults
    /// </summary>
    partial void CustomInit();

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "alt")]
    public string Alt { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "day")]
    public string Day { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "img")]
    public string Img { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "link")]
    public string Link { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "month")]
    public string Month { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "news")]
    public string News { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "num")]
    public double? Num { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "safe_title")]
    public string SafeTitle { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "transcript")]
    public string Transcript { get; set; }

    /// <summary>
    /// </summary>
    [JsonProperty(PropertyName = "year")]
    public string Year { get; set; }

}
