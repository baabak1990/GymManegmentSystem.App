using GymManegmentSystem.UI.Contracts;
using Hanssens.Net;

namespace GymManegmentSystem.UI.Services
{
    public class LocalStorageServices : ILocalStorageServices
    {
        //All of this configurations come from LocalStorage library
        private LocalStorage _storage;

        public LocalStorageServices()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "GymManagement"
            };
            _storage = new LocalStorage(config);
        }
        public void ClearStorage(List<string> keys)
        {
            foreach (var key in keys)
            {
                _storage.Remove(key);
            }
        }

        public bool Exists(string key)
        {
            return _storage.Exists(key);
        }

        public T GetStorageValue<T>(string key)
        {
            return _storage.Get<T>(key);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}
