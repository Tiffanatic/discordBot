namespace DiscordBot
{
    public interface IDataStorage
    {
        void StoreObject(object obj, string key);

        T GetObject<T>(string key);
    }
}
