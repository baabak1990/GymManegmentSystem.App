using System.Net.Http.Headers;
using GymManagement.UI.Asp.NetMVC.Contracts;

namespace GymManagement.UI.Asp.NetMVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly ILocalStorageServices _storageServices;
        protected IClient _client;

        public BaseHttpService(ILocalStorageServices storageServices, IClient client)
        {
            _storageServices = storageServices;
            _client = client;
        }
        //With This Method We Convert Base ApiExecption into Our Costumed Response Class
        protected Response<Guid> ConvertApiExecptions<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<Guid>()
                {
                    Message = "Validation Errors Have Occured",
                    ValidationError = ex.Response,
                    Success = false
                };

            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>()
                {
                    Message = "The Request item could not be found",
                    Success = false
                };
            }
            else
            {
                return new Response<Guid>()
                {
                    Message = "Something went wrong , Please try again !!",
                    Success = false
                };
            }

        }

        protected void AddBearerToken()
        {
            if (_storageServices.Exist("token"))
                _client.HttpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", _storageServices.GetStorageValue<string>("token"));
        }
    }
}
