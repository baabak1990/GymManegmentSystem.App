using AutoMapper;
using GymManagement.UI.Asp.NetMVC.Contracts;
using GymManagement.UI.Asp.NetMVC.Models.MemberShipVM;

namespace GymManagement.UI.Asp.NetMVC.Services.Base
{
    public class MembershipServices: BaseHttpService, IMembershipServices
    {
        #region Constructor

        private readonly ILocalStorageServices _storageServices;
        private readonly IMapper _mapper;
        protected IClient _client;

        public MembershipServices(ILocalStorageServices storageServices, IClient client, IMapper mapper) : base(storageServices, client)
        {
            _storageServices = storageServices;
            _client = client;
            _mapper = mapper;
        }

        #endregion

        public async Task<List<MembershipVM>> GetMembersAsync()
        {
            var memberships = await _client.MembershipAllAsync();
            return _mapper.Map<List<MembershipVM>>(memberships);
        }

        public async Task<MembershipVM> GetMemberAsync(int id)
        {
            var membership = await _client.MembershipGETAsync(id);
            return _mapper.Map<MembershipVM>(membership);
        }

        public async Task<Response<int>> CreateMember(CreateMembershipVM vm)
        {
            try
            {
                var response = new Response<int>();
                CreateMembershipDTO dto = _mapper.Map<CreateMembershipDTO>(vm);
                var apiResponse = await _client.MembershipPOSTAsync(dto);
                if (apiResponse.IsSuccess)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }

                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExecptions<int>(ex);
            }
        }

        public async Task<Response<int>> UpdateMember(int id, MembershipVM vm)
        {
            try
            {
                EditMemberShipDTo dto = _mapper.Map<EditMemberShipDTo>(vm);
                await _client.MembershipPUTAsync(id, dto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExecptions<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteMember(int id)
        {
            try
            {
                await _client.MemberDELETEAsync(id);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExecptions<int>(ex);
            }
        }
    }
}
