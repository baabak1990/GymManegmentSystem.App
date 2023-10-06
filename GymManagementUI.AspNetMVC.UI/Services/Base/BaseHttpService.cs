using System.Net.Http.Headers;
using GymManagementUI.AspNetMVC.UI.Contracts;

namespace GymManagementUI.AspNetMVC.UI.Services.Base
{
	public class BaseHttpService
	{
		#region Constructor

		protected readonly ILocalStorageService _localStorage;
		protected IClient _client;

		public BaseHttpService(IClient client,ILocalStorageService localStorage)
		{
			_client=client;
			_localStorage=localStorage;
		}


		#endregion


		protected Response<Guid> ConvertApiExceptions<Guid>(ApiException ex)
		{
			if (ex.StatusCode == 400)
			{
				return new Response<Guid>()
				{
					Message = "Validation Errors Have occurred.",
					ValidationError = ex.Response,
					Success = false,

				};
			}
			else if (ex.StatusCode ==404)
			{
				return new Response<Guid>()
				{
					Message = "The Request Item Dose not Found.",
					ValidationError = ex.Response,
					Success = false,
				};
			}
			else
			{
				return new Response<Guid>()
				{
					Message = "Something went wrong , Please Try Again .",
					ValidationError = ex.Response,
					Success = false,
				};
			}
		}

		protected void AddBearerToken()
		{
			if (_localStorage.Exists("token"))
				_client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
					"Bearer",
					_localStorage.GetStorageValue<string>("token")
				);
		}
	}
}
