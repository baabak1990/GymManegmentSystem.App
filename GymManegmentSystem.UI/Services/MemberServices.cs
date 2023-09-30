using AutoMapper;
using GymManegmentSystem.UI.Contracts;
using GymManegmentSystem.UI.Models.MemberVm;
using GymManegmentSystem.UI.Services.Base;

namespace GymManegmentSystem.UI.Services
{
    public class MemberServices:BaseHttpServices,IMemberServices
    {
        #region Constructor
        private readonly ILocalStorageServices _storageServices;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;
        public MemberServices(ILocalStorageServices storageServices, IClient client, IMapper mapper) : base(storageServices, client)
        {
            _storageServices = storageServices;
            _httpclient = client;
            _mapper = mapper;
        }

        #endregion
        public async Task<List<MemberVM>> GetMembers()
        {
            //This _client comes from BaseHttpServices class 
            var members = await _client.MemberAllAsync();
            return _mapper.Map<List<MemberVM>>(members);
        }

        public async Task<MemberVM> GetMemberWithDetails(int id)
        {
            //This _client comes from BaseHttpServices class 
            var member = await _client.MemberGETAsync(id);
            return _mapper.Map<MemberVM>(member);
        }

        public Task<Response<int>> CreateMember(CreateMemberVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> UpdateMember(int id, MemberVM vm)
        {
            throw new NotImplementedException();
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
                //This method comes from BassHttpsServices
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}
