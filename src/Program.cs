using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ComicsAppWasm.ComicsService;
using ComicsAppWasm.ComicsService.ComicSources.Xkcd;
using ComicsAppWasm.ComicsService.ComicSources.Garfield;
using ComicsAppWasm.ComicsService.ComicSources.Dilbert;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes;
using ComicsAppWasm;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IXKCD, XKCD>(p => new XKCD(new HttpClient(), true));

builder.Services.AddScoped<IXkcdComic, XkcdComic>();
builder.Services.AddScoped<IGarfield, Garfield>();
builder.Services.AddScoped<IDilbert, Dilbert>();
builder.Services.AddScoped<ICalvinAndHobbes, CalvinAndHobbes>();
builder.Services.AddScoped<IComicUrlService, ComicUrlService>();

await builder.Build().RunAsync();
