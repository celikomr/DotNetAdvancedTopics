using Microsoft.Extensions.Caching.Memory;

namespace Caching.Managers;

public class MemoryCacheManager : ICacheManager
{
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
        throw new NotImplementedException();
    }

    public T Get<T>(string key)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll<T>()
    {
        throw new NotImplementedException();
    }

    public T GetOrSet<T>(string key, Func<T> getDataFunc, TimeSpan expirationTime, IEnumerable<string> dependencies = null, bool useLazyLoading = true)
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
