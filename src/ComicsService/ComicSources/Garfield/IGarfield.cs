﻿using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.Garfield
{
    public interface IGarfield
    {
        Task<string> GetGarfieldComicUri();
    }
}