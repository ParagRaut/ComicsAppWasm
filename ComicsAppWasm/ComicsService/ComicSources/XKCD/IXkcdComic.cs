﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicsAppWasm.ComicsService.ComicSources.XKCD
{
    public interface IXkcdComic
    {
        Task<string> GetXkcdComicUri();
    }
}