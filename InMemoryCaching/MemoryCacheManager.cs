using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching;

public class MemoryCacheManager : IMemoryCacheManager
{
    private readonly IMemoryCache _cache;

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool ContainsKey(string key)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        _cache.Dispose();
    }

    public T Get<T>(string key)
    {
        if (_cache.TryGetValue(key, out T value))
        {
            return value;
        }

        return default;
    }

    public IEnumerable<T> GetAll<T>()
    {
        throw new NotImplementedException();
    }

    public T GetOrSet<T>(string key, Func<T> getDataFunc, TimeSpan expirationTime, IEnumerable<string> dependencies = null, bool useLazyLoading = true)
    {
        throw new NotImplementedException();
    }

    public long GetSize()
    {
        throw new NotImplementedException();
    }

    public long GetSizeInBytes()
    {
        throw new NotImplementedException();
    }

    public void Remove(string key)
    {
        throw new NotImplementedException();
    }

    public void Set<T>(string key, T value, TimeSpan expirationTime, IEnumerable<string> dependencies = null)
    {
        throw new NotImplementedException();
    }

    public void SetCapacity(int size)
    {
        throw new NotImplementedException();
    }

    public void SetOptions(string key, MemoryCacheEntryOptions options)
    {
        throw new NotImplementedException();
    }
}
