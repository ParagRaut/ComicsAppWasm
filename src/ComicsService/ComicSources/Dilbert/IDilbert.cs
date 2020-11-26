using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.Dilbert
{
    public interface IDilbert
    {
        Task<string> GetDilbertComicUri();
    }
}