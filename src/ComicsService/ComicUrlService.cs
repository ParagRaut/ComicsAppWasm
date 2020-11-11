﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources;
using ComicsAppWasm.ComicsService.ComicSources.CalvinAndHobbes;
using ComicsAppWasm.ComicsService.ComicSources.DilbertComics;
using ComicsAppWasm.ComicsService.ComicSources.GarfieldComics;
using ComicsAppWasm.ComicsService.ComicSources.XKCD;
using Microsoft.Extensions.Logging;

namespace ComicsAppWasm.ComicsService
{
    public class ComicUrlService : IComicUrlService
    {
        public ComicUrlService([NotNull] IXkcdComic xkcdComic,
            [NotNull] IGarfieldComics garfieldComics,
            [NotNull] IDilbertComics dilbertComics,
            [NotNull] ICalvinAndHobbesComics calvinAndHobbesComics,
            [NotNull] ILogger<ComicUrlService> logger)
        {
            this.XkcdComicsService = xkcdComic;
            this.GarfieldComicsService = garfieldComics;
            this.DilbertComicsService = dilbertComics;
            this.CalvinAndHobbesComicsService = calvinAndHobbesComics;
            this._logger = logger;
        }

        private IXkcdComic XkcdComicsService { get; }

        private IGarfieldComics GarfieldComicsService { get; }

        private IDilbertComics DilbertComicsService { get; }
        private ICalvinAndHobbesComics CalvinAndHobbesComicsService { get; }

        private Task<string> ComicImageUri { get; set; }

        private readonly ILogger _logger;

        public Task<string> GetRandomComic()
        {
            ComicEnum comicName = this.ChooseRandomComicSource();

            switch (comicName)
            {
                case ComicEnum.Garfield:
                    this.ComicImageUri = this.GetGarfieldComic();
                    break;
                case ComicEnum.Xkcd:
                    this.ComicImageUri = this.GetXkcdComic();
                    break;
                case ComicEnum.Dilbert:
                    this.ComicImageUri = this.GetDilbertComic();
                    break;
                case ComicEnum.CalvinAndHobbes:
                    this.ComicImageUri = this.GetCalvinAndHobbesComic();
                    break;
                default:
                    this._logger.LogInformation("Argument exception is thrown");
                    throw new ArgumentOutOfRangeException();
            }

            return this.ComicImageUri;
        }

        private ComicEnum ChooseRandomComicSource()
        {
            var random = new Random();
            return (ComicEnum)random.Next(Enum.GetNames(typeof(ComicEnum)).Length);
        }

        public Task<string> GetDilbertComic()
        {
            this._logger.LogInformation($"Returning Dilbert comic strip");
            return this.DilbertComicsService.GetDilbertComicUri();
        }

        public Task<string> GetGarfieldComic()
        {
            this._logger.LogInformation($"Returning Garfield comic strip");
           
            return Task.Run(() => this.GarfieldComicsService.GetGarfieldComicUri());
        }

        public Task<string> GetXkcdComic()
        {
            this._logger.LogInformation($"Returning XKCD comic strip");
            return this.XkcdComicsService.GetXkcdComicUri();
        }

        public Task<string> GetCalvinAndHobbesComic()
        {
            this._logger.LogInformation($"Returning Calvin and Hobbes comic strip");
            return this.CalvinAndHobbesComicsService.CalvinAndHobbesComicUri();
        }
    }
}