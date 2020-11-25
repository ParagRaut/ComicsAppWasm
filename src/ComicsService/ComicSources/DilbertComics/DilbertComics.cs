using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics.DilbertService;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public class DilbertComics : IDilbertComics
    {
        public async Task<string> GetDilbertComicUri()
        {
            return await DilbertServiceApi.GetDilbertComicsUrl();
        }
    }
}