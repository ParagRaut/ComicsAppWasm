using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public interface IDilbertComics
    {
        Task<string> GetDilbertComicUri();
    }
}