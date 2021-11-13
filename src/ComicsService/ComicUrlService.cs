using System.Diagnostics.CodeAnalysis;
using ComicsAppWasm.ComicsService.ComicSources;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes;
using ComicsAppWasm.ComicsService.ComicSources.Dilbert;
using ComicsAppWasm.ComicsService.ComicSources.Garfield;
using ComicsAppWasm.ComicsService.ComicSources.Xkcd;

namespace ComicsAppWasm.ComicsService;

public class ComicUrlService : IComicUrlService
{
    private readonly IXkcdComic _xkcd;
    private readonly IGarfield _garfield;
    private readonly IDilbert _dilbert;
    private readonly ICalvinAndHobbes _calvinAndHobbes;
    private readonly ILogger<ComicUrlService> _logger;

    public ComicUrlService([NotNull] IXkcdComic xkcd,
        [NotNull] IGarfield garfield,
        [NotNull] IDilbert dilbert,
        [NotNull] ICalvinAndHobbes calvinAndHobbes,
        [NotNull] ILogger<ComicUrlService> logger)
    {
        _xkcd = xkcd;
        _garfield = garfield;
        _dilbert = dilbert;
        _calvinAndHobbes = calvinAndHobbes;
        _logger = logger;
    }

    public Task<string> GetRandomComic()
    {
        ComicEnum comicName = ChooseRandomComicSource();

        return comicName switch
        {
            ComicEnum.Garfield => GetGarfieldComic(),
            ComicEnum.Xkcd => GetXkcdComic(),
            ComicEnum.Dilbert => GetDilbertComic(),
            ComicEnum.CalvinAndHobbes => GetCalvinAndHobbesComic(),
            _ => throw new ArgumentOutOfRangeException()
        };
    }

    private static ComicEnum ChooseRandomComicSource()
    {
        var random = new Random();

        return (ComicEnum)random.Next(Enum.GetNames(typeof(ComicEnum)).Length);
    }

    public Task<string> GetDilbertComic()
    {
        _logger.LogInformation($"Returning Dilbert comic strip");

        return _dilbert.GetDilbertComicUri();
    }

    public Task<string> GetGarfieldComic()
    {
        _logger.LogInformation($"Returning Garfield comic strip");

        return _garfield.GetGarfieldComicUri();
    }

    public Task<string> GetXkcdComic()
    {
        _logger.LogInformation($"Returning XKCD comic strip");

        return _xkcd.GetXkcdComicUri();
    }

    public Task<string> GetCalvinAndHobbesComic()
    {
        _logger.LogInformation($"Returning Calvin and Hobbes comic strip");

        return _calvinAndHobbes.CalvinAndHobbesComicUri();
    }
}
