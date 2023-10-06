using GymManagementUI.AspNetMVC.UI.Contracts;
using Hanssens.Net;

namespace GymManagementUI.AspNetMVC.UI.Services
{
	public class LocalStorageService:ILocalStorageService
	{
		//That`s Directly come from hanssens library!!!
		private LocalStorage _storage;

		public LocalStorageService()
		{
			var config = new LocalStorageConfiguration()
			{
				AutoLoad = true,
				AutoSave = true,
				Filename = "Gym,Management"
			};
			//*********************************//
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
			_storage.Store(key,value);
			_storage.Persist();
		}
	}
}
