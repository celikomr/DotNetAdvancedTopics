using Microsoft.Extensions.Caching.Memory;

namespace InMemoryCaching;

public interface IMemoryCacheManager : IDisposable
{
    public void Clear();
    public bool ContainsCacheKey(string key);
    public T Get<T>(string key);
    public IEnumerable<T> GetAll<T>();
    public long GetCacheSize();
    public long GetCacheSizeInBytes();
    public void Remove(string key);
    public void Set<T>(string key, T value, TimeSpan expirationTime, IEnumerable<string> dependencies = null);
    public void SetCacheCapacity(int size);
    // public void RemoveCacheEntryRemovedCallback(CacheEntryRemovedCallback callback);
    public void SetCacheOptions(string key, MemoryCacheEntryOptions options);

    // public void RegisterCacheEntryRemovedCallback(CacheEntryRemovedCallback callback);
}
