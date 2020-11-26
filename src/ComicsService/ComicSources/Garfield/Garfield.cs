using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.Garfield
{
    public class Garfield : IGarfield
    {
        public Task<string> GetGarfieldComicUri()
        {
            return Service.GetComicUri();
        }
    }
}