﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using ComicsAppWasm.ComicsService.ComicSources;
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
            [NotNull] IDilbertComics gDilbertComics,
            ILogger<ComicUrlService> logger)
        {
            this.XkcdComicsService = xkcdComic;
            this.GarfieldComicsService = garfieldComics;
            this.DilbertComicsService = gDilbertComics;
            this._logger = logger;
        }

        private IXkcdComic XkcdComicsService { get; }

        private IGarfieldComics GarfieldComicsService { get; }

        private IDilbertComics DilbertComicsService { get; }

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
                default:
                    this._logger.LogInformation("Argument exception is thrown");
                    throw new ArgumentOutOfRangeException();
            }

            this._logger.LogInformation($"Returning {comicName} comic strip");

            return this.ComicImageUri;
        }

        private ComicEnum ChooseRandomComicSource()
        {
            var random = new Random();
            return (ComicEnum)random.Next(Enum.GetNames(typeof(ComicEnum)).Length);
        }

        public Task<string> GetDilbertComic()
        {
            return this.DilbertComicsService.GetDilbertComicUri();
        }

        public Task<string> GetGarfieldComic()
        {
            return this.GarfieldComicsService.GetGarfieldComicUri();
        }

        public Task<string> GetXkcdComic()
        {
            return this.XkcdComicsService.GetXkcdComicUri();
        }
    }
}