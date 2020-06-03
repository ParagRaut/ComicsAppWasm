using System;
using System.Net.Http;
using System.Threading.Tasks;
using ComicsAppWasm.ComicsService;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics;
using ComicsAppWasm.ComicsService.ComicSources.GarfieldComics;
using ComicsAppWasm.ComicsService.ComicSources.XKCD;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ComicsAppWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IXKCD, XKCD>(p => new XKCD(new HttpClient(), true));

            builder.Services.AddScoped<IXkcdComic, XkcdComic>();
            builder.Services.AddScoped<IGarfieldComics, GarfieldComics>();
            builder.Services.AddScoped<IDilbertComics, DilbertComics>();
            builder.Services.AddScoped<ICalvinAndHobbesComics, CalvinAndHobbesComics>();
            builder.Services.AddScoped<IComicUrlService, ComicUrlService>();

            await builder.Build().RunAsync();
        }
    }
}
