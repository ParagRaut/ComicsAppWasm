using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes
{
    public interface ICalvinAndHobbes
    {
        Task<string> CalvinAndHobbesComicUri();
    }
}
