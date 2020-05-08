using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService
{
    public interface IComicUrlService
    {
        Task<string> GetRandomComic();
        Task<string> GetDilbertComic();
        Task<string> GetGarfieldComic();
        Task<string> GetXkcdComic();
    }
}