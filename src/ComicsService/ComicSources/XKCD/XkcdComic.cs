using System.Diagnostics;
using ComicsAppWasm.ComicsService.ComicSources.Xkcd.Models;

namespace ComicsAppWasm.ComicsService.ComicSources.Xkcd;

public class XkcdComic : IXkcdComic
{
    public XkcdComic(IXKCD xKcdComics)
    {
        this.XkcdService = xKcdComics;
    }

    private IXKCD XkcdService { get; }

    public async Task<string> GetXkcdComicUri()
    {
        int comicId = await this.GetRandomComicNumber();

        string comicImageUri = await this.GetImageUri(comicId);

        return comicImageUri;
    }

    private async Task<int> GetLatestComicId()
    {
        Comic response = await this.XkcdService.GetLatestComicAsync();
        Debug.Assert(response.Num != null, "response.Num != null");

        return (int)response.Num.Value;
    }

    private async Task<int> GetRandomComicNumber()
    {
        int maxId = await this.GetLatestComicId();
        var randomNumber = new Random();
        return randomNumber.Next(maxId);
    }

    private async Task<string> GetImageUri(int comicId)
    {
        Comic comicImage = await this.XkcdService.GetComicByIdAsync(comicId).ConfigureAwait(false);

        return comicImage.Img;
    }
}
