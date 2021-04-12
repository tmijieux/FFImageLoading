using System.Threading;
using System.Threading.Tasks;

namespace FFImageLoading.Work
{
	public interface IDataResolver
	{
		Task<DataResolverResult> Resolve(string identifier, TaskParameter parameters, CancellationToken token);
	}
}
