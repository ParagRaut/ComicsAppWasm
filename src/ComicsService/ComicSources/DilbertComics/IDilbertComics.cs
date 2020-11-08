using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public interface IDilbertComics
    {
        Task<string> GetDilbertComicUri();
    }
}