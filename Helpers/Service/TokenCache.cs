using Helpers.Interface;
using System;
using System.Runtime.Caching;

namespace Helpers.Service
{
    public class TokenCache : ITokenCache
    {
        private static ObjectCache cache = MemoryCache.Default;
        private static string cacheName = "TokenCache";
        public string CheckCache()
        {
            var cachedToken = cache[cacheName] as string;
            if (cachedToken == null) return string.Empty;
            else return cachedToken;
        }

        public void StoreCache(string token)
        {
            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTimeOffset.Now.AddHours(1);
            cache.Set(cacheName, token, policy);
        }
    }
}
