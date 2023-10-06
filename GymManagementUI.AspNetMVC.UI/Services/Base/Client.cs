namespace GymManagementUI.AspNetMVC.UI.Services.Base
{
	public partial class Client:IClient
	{
		public HttpClient HttpClient {
			get
			{
				//This _hhtp is a private filed in client class originally
				return _httpClient;
			}
		}

	}
}
