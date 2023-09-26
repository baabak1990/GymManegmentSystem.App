using System.Net.Http.Headers;
using GymManegmentSystem.UI.Contracts;

namespace GymManegmentSystem.UI.Services.Base
{
    public class BaseHttpServices
    {
        protected readonly ILocalStorageServices _storageServices;
        protected IClient _client;

        public BaseHttpServices(ILocalStorageServices storageServices, IClient client)
        {
            _storageServices = storageServices;
            _client = client;
        }

        //ApiException Is Exist in IClient Interface 
        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<Guid>()
                { Message = "Validation Errors Have Occured", ValidationErrors = ex.Response, Success = false };

            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "The Requested Item Could not be Found", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "Something went wrong , please Try Again .", Success = false };
            }

        }

        protected void AddBearerToken()
        {
            if (_storageServices.Exists("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _storageServices.GetStorageValue<string>("token"));

        }
    }
}
