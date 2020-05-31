using ComicsAppWasm.ComicsService.ComicSources.GarfieldComics.GarfieldService;

namespace ComicsAppWasm.ComicsService.ComicSources.GarfieldComics
{
    public class GarfieldComics : IGarfieldComics
    {
        public string GetGarfieldComicUri()
        {
            var garfieldServiceApi = new GarfieldServiceApi();
            return garfieldServiceApi.GetGarfieldComicsUrl();        
        }
    }
}