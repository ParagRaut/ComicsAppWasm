using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.GarfieldComics.GarfieldService;

namespace ComicsAppWasm.ComicsService.ComicSources.GarfieldComics
{
    public class GarfieldComics : IGarfieldComics
    {
        public Task<string> GetGarfieldComicUri()
        {
            return GarfieldServiceApi.GetGarfieldComicsUrl();
        }
    }
}