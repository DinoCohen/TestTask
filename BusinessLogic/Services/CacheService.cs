using Models.Services;
using System;
using Microsoft.Extensions.Caching.Memory;

namespace BusinessLogic.Services
{
    public class CacheService : ICacheService
    {
        private readonly IMemoryCache _memoryCache;

        public CacheService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public T GetItem<T>(string key)
        {
            object cachedItem = _memoryCache.Get(key);
            return (T)cachedItem;
        }

        public void SetItem<T>(string key, T item)
        {
            _memoryCache.Set<T>(key, item);
        }
    }
}
