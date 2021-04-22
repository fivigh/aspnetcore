
// Single resource
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Internal
{
    public interface IResourceLimiter
    {
        // an inaccurate view of resources
        long EstimatedCount { get; }

        // Fast synchronous attempt to acquire resources
        bool TryAcquire(long requestedCount, out Resource? resource);

        // Wait until the requested resources are available
        // If unsuccessful, throw
        ValueTask<Resource> AcquireAsync(long requestedCount, CancellationToken cancellationToken = default);
    }
}