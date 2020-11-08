
using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.GarfieldComics
{
    public interface IGarfieldComics
    {
        Task<string> GetGarfieldComicUri();
    }
}