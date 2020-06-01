using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes
{
    public interface ICalvinAndHobbesComics
    {
        Task<string> CalvinAndHobbesComicUri();
    }
}
