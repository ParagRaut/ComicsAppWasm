using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using ComicsAppWasm.ComicsService;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics;
using ComicsAppWasm.ComicsService.ComicSources.GarfieldComics;
using ComicsAppWasm.ComicsService.ComicSources.XKCD;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace ComicsAppWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddSingleton<IXKCD, XKCD>(p => new XKCD(new HttpClient(), true));

            builder.Services.AddSingleton<IXkcdComic, XkcdComic>();
            builder.Services.AddSingleton<IGarfieldComics, GarfieldComics>();
            builder.Services.AddSingleton<IDilbertComics, DilbertComics>();
            builder.Services.AddSingleton<IComicUrlService, ComicUrlService>();

            await builder.Build().RunAsync();
        }
    }
}
