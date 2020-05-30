using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics.DilbertService;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public class DilbertComics : IDilbertComics
    {
        public async Task<string> GetDilbertComicUri()
        {
            DilbertServiceApi dilbertServiceApi = new DilbertServiceApi();

            string comicStripUri = await dilbertServiceApi.GetDilberComicsUrl();

            comicStripUri = $"https:{comicStripUri}.png";

            return comicStripUri;
        }
    }
}