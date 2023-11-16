
using AutoMapper;
using GymManagement.UI.Asp.NetMVC.Contracts;
using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using GymManagement.UI.Asp.NetMVC.Services.Base;
using Gender = GymManagement.UI.Asp.NetMVC.Models.MemberVM.Gender;

namespace GymManagement.UI.Asp.NetMVC.Services
{
    public class MemberService : BaseHttpService, IMemberServices
    {
        #region Constructor
        private readonly ILocalStorageServices _storageServices;
        private readonly IMapper _mapper;
        private IClient _httpclient;

        public MemberService(ILocalStorageServices storageServices, IClient client, IMapper mapper) : base(storageServices, client)
        {
            _storageServices = storageServices;
            _client = client;
            _mapper = mapper;
        }

        #endregion


        public async Task<List<MemberVm>> GetMembersAsync()
        {
            var members = await _client.GetWithDetailsAsync();
            return _mapper.Map<List<MemberVm>>(members);
        }

        public async Task<MemberVm> GetMemberAsync(int id)
        {
            var member = await _client.GetMembersWithDetailsAsync(id);
            return _mapper.Map<MemberVm>(member);
        }

        public async Task<Response<int>> CreateMember(CreateMemberVm vm)
        {

            try
            {
                // Our return type in command feature is baseCommandResponse
                var response = new Response<int>();
                CreateMemberDto dto = _mapper.Map<CreateMemberDto>(vm);
                if (vm.Gender == Gender.Female)
                {
                    dto.Avatar = "2.jpg";
                }
                else
                {
                    dto.Avatar = "1.jpg";
                }
                dto.IsPresent = true;
                dto.IsValid = true;
                var apiResponse = await _client.MemberPOSTAsync(dto);
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

        public async Task<Response<int>> UpdateMember(int id, MemberVm vm)
        {
            try
            {
                //First we have to Create an instance of MemberEditDTO because the client method needs that
                EditMemberDto dto = _mapper.Map<EditMemberDto>(vm);
                await _client.MemberPUTAsync(id.ToString(), dto);
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
