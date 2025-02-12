namespace Helpers.Interface
{
    public interface ITokenCache
    {
        void StoreCache(string token);
        string CheckCache();
    }
}
