namespace ComicsAppWasm.ComicsService.XKCD;

public interface IXKCDService
{
    Task<string> GetComicUri();
}
