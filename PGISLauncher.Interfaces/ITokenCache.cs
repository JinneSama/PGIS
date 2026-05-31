namespace PGISLauncher.Interfaces
{
    public interface ITokenCache
    {
        void StoreCache(string token);
        string CheckCache();
    }
}
