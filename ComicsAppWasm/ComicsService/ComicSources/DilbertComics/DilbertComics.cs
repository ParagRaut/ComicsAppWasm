﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComicsAppWasm.ComicsService.ComicSources.DilbertComics
{
    public class DilbertComics : IDilbertComics
    {
        public DilbertComics()
        {
            this.BaseUri = new Uri("https://cors-anywhere.herokuapp.com/https://discordians-api.herokuapp.com/comic");
        }

        private Uri BaseUri { get; }

        private ComicModel ComicModel { get; set; }

        public async Task<string> GetDilbertComicUri()
        {
            var comicUri = new Uri($"{this.BaseUri}/dilbert");


            var httpClient = new HttpClient();

            string response = await httpClient.GetStringAsync(comicUri);
            this.ComicModel = JsonConvert.DeserializeObject<ComicModel>(response);


            this.ComicModel.image = $"https:{this.ComicModel.image}.png";

            return this.ComicModel.image;
        }
    }
}