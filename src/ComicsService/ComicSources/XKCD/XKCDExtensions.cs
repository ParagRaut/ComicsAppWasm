// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ComicsAppWasm.ComicsService.ComicSources.Xkcd;

using Models;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Extension methods for XKCD.
/// </summary>
public static partial class XKCDExtensions
{
    /// <summary>
    /// Fetch current comic and metadata.
    ///
    /// </summary>
    /// <param name='operations'>
    /// The operations group for this extension method.
    /// </param>
    public static Comic GetLatestComic(this IXKCD operations)
    {
        return operations.GetLatestComicAsync().GetAwaiter().GetResult();
    }

    /// <summary>
    /// Fetch current comic and metadata.
    ///
    /// </summary>
    /// <param name='operations'>
    /// The operations group for this extension method.
    /// </param>
    /// <param name='cancellationToken'>
    /// The cancellation token.
    /// </param>
    public static async Task<Comic> GetLatestComicAsync(this IXKCD operations, CancellationToken cancellationToken = default(CancellationToken))
    {
        using (var _result = await operations.GetLatestComicWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
        {
            return _result.Body;
        }
    }

    /// <summary>
    /// Fetch comics and metadata  by comic id.
    ///
    /// </summary>
    /// <param name='operations'>
    /// The operations group for this extension method.
    /// </param>
    /// <param name='comicId'>
    /// </param>
    public static Comic GetComicById(this IXKCD operations, int comicId)
    {
        return operations.GetComicByIdAsync(comicId).GetAwaiter().GetResult();
    }

    /// <summary>
    /// Fetch comics and metadata  by comic id.
    ///
    /// </summary>
    /// <param name='operations'>
    /// The operations group for this extension method.
    /// </param>
    /// <param name='comicId'>
    /// </param>
    /// <param name='cancellationToken'>
    /// The cancellation token.
    /// </param>
    public static async Task<Comic> GetComicByIdAsync(this IXKCD operations, int comicId, CancellationToken cancellationToken = default(CancellationToken))
    {
        using (var _result = await operations.GetComicByIdWithHttpMessagesAsync(comicId, null, cancellationToken).ConfigureAwait(false))
        {
            return _result.Body;
        }
    }

}
