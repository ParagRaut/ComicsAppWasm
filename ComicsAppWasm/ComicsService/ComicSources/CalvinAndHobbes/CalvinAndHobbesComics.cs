using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes.CalvinAndHobbesService;

namespace ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes
{
    public class CalvinAndHobbesComics : ICalvinAndHobbesComics
    {
        public async Task<string> CalvinAndHobbesComicUri()
        {
            var calvinAndHobsServiceApi = new CalvinAndHobbesServiceApi();

            string comicStripUri = await calvinAndHobsServiceApi.CalvinAndHobsComicUrl();

            return comicStripUri;
        }
    }
}
