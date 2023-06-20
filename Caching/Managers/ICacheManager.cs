using Microsoft.Extensions.Caching.Memory;

namespace Caching.Managers;

public interface ICacheManager
{
    public void Clear();
    public bool ContainsKey(string key);
    public T Get<T>(string key);
    public IEnumerable<T> GetAll<T>();
    public T GetOrSet<T>(string key, Func<T> getDataFunc, TimeSpan expirationTime, IEnumerable<string> dependencies = null, bool useLazyLoading = true);
    public long GetSize();
    public long GetSizeInBytes();
    public void Remove(string key);
    public void Set<T>(string key, T value, TimeSpan expirationTime, IEnumerable<string> dependencies = null);
    public void SetCapacity(int size);
    public void SetOptions(string key, MemoryCacheEntryOptions options);
}
