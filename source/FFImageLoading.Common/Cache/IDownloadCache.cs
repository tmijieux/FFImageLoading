using System.Threading;
using System.Threading.Tasks;
using FFImageLoading.Config;
using FFImageLoading.Work;

namespace FFImageLoading.Cache
{
	[Preserve(AllMembers = true)]
	public interface IDownloadCache
	{
		Task<CacheStream> DownloadAndCacheIfNeededAsync(string url, TaskParameter parameters, Configuration configuration, CancellationToken token);
	}
}

