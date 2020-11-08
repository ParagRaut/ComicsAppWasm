using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.XKCD
{
    public interface IXkcdComic
    {
        Task<string> GetXkcdComicUri();
    }
}