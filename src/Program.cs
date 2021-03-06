using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ComicsAppWasm.ComicsService;
using ComicsAppWasm.ComicsService.ComicSources.Xkcd;
using ComicsAppWasm.ComicsService.ComicSources.Garfield;
using ComicsAppWasm.ComicsService.ComicSources.Dilbert;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes;

namespace ComicsAppWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IXKCD, XKCD>(p => new XKCD(new HttpClient(), true));

            builder.Services.AddScoped<IXkcdComic, XkcdComic>();
            builder.Services.AddScoped<IGarfield, Garfield>();
            builder.Services.AddScoped<IDilbert, Dilbert>();
            builder.Services.AddScoped<ICalvinAndHobbes, CalvinAndHobbes>();
            builder.Services.AddScoped<IComicUrlService, ComicUrlService>();

            await builder.Build().RunAsync();
        }
    }
}
