using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes.CalvinAndHobbesService;

namespace ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes
{
    public class CalvinAndHobbesComics : ICalvinAndHobbesComics
    {
        public async Task<string> CalvinAndHobbesComicUri()
        {
            return await CalvinAndHobbesServiceApi.CalvinAndHobbesComicUrl();
        }
    }
}
