using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.Dilbert
{
    public class Dilbert : IDilbert
    {
        public async Task<string> GetDilbertComicUri()
        {
            return await Service.GetComicUri();
        }
    }
}