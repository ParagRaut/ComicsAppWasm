using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComicsAppWasm.ComicsService.ComicSources.GarfieldComics
{
    public interface IGarfieldComics
    {
        Task<string> GetGarfieldComicUri();
    }
}