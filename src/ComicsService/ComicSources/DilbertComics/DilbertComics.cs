using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics.DilbertService;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public class DilbertComics : IDilbertComics
    {
        public async Task<string> GetDilbertComicUri()
        {
            var dilbertServiceApi = new DilbertServiceApi();

            string comicStripUri = await dilbertServiceApi.GetDilbertComicsUrl();

            return comicStripUri;
        }
    }
}