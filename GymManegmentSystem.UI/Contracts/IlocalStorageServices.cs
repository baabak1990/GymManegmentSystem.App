namespace GymManegmentSystem.UI.Contracts;

public interface ILocalStorageServices
{
    void ClearStorage(List<string> keys);
    bool Exists(string key);
    T GetStorageValue<T>(string key);
    void SetStorageValue<T>(string key,T  value);
}