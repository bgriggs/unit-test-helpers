using Microsoft.Extensions.Caching.Hybrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMission.TestHelpers.Testing;

public class HybridCacheShell : HybridCache
{
    private Dictionary<string, string> cache = [];

    public override ValueTask<T> GetOrCreateAsync<TState, T>(string key, TState state, Func<TState, CancellationToken, ValueTask<T>> factory, HybridCacheEntryOptions? options = null, IEnumerable<string>? tags = null, CancellationToken cancellationToken = default)
    {
        if (cache.TryGetValue(key, out var value))
        {
            return new ValueTask<T>((T)Convert.ChangeType(value, typeof(T)));
        }
        var result = factory(state, cancellationToken);
        cache[key] = result.ToString()!;
        return result;
    }

    public override ValueTask RemoveAsync(string key, CancellationToken cancellationToken = default)
    {
        cache.Remove(key);
        return ValueTask.CompletedTask;
    }

    public override ValueTask RemoveByTagAsync(string tag, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public override ValueTask SetAsync<T>(string key, T value, HybridCacheEntryOptions? options = null, IEnumerable<string>? tags = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
