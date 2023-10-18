using GymManagement.UI.Asp.NetMVC.Contracts;
using Hanssens.Net;

namespace GymManagement.UI.Asp.NetMVC.Services
{
    public class LocalStorageServices : ILocalStorageServices
    {
        private LocalStorage _localStorage;
        public LocalStorageServices()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "Gym.Management"
            };
            _localStorage = new LocalStorage(config);
        }
        public void ClearStorage(List<string> keys)
        {
            foreach (var key in keys)
            {
                _localStorage.Remove(key);
            }
        }
        public bool Exist(string key)
        {
            return _localStorage.Exists(key);
        }
        public T GetStorageValue<T>(string key)
        {
            return _localStorage.Get<T>(key);
        }
        public void SetStorageValue<T>(string key, T value)
        {
            _localStorage.Store(key, value);
            _localStorage.Persist();
        }
    }
}
