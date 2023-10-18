namespace GymManagement.UI.Asp.NetMVC.Services.Base
{
    public partial class Client : IClient
    {
        //This HTTPClient came from other IClient Partial Interface
        public HttpClient HttpClient
        {
            get => _httpClient;
        }
    }
}
