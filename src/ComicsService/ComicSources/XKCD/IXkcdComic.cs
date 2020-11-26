using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.Xkcd
{
    public interface IXkcdComic
    {
        Task<string> GetXkcdComicUri();
    }
}