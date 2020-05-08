using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ComicsAppWasm.ComicsService.ComicSources.GarfieldComics
{
    public class GarfieldComics : IGarfieldComics
    {
        public GarfieldComics()
        {
            this.BaseUri = new Uri("https://cors-anywhere.herokuapp.com/https://discordians-api.herokuapp.com/comic");
        }

        private Uri BaseUri { get; }

        private ComicModel ComicModel { get; set; }

        public async Task<string> GetGarfieldComicUri()
        {
            var comicUri = new Uri($"{this.BaseUri}/garfield");

            var httpClient = new HttpClient();

            string response = await httpClient.GetStringAsync(comicUri);
            this.ComicModel = JsonConvert.DeserializeObject<ComicModel>(response);
            
            return this.ComicModel.image;
        }
    }
}