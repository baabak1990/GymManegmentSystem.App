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
        private readonly IClient _client;
        public MemberServices(ILocalStorageServices storageServices, IClient client, IMapper mapper) : base(storageServices, client)
        {
            _storageServices = storageServices;
            _client = client;
            _mapper = mapper;
        }

        #endregion
        public Task<List<MemberVM>> GetMembers()
        {
            throw new NotImplementedException();
        }

        public Task<MemberVM> GetMemberWithDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> CreateMember(CreateMemberVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> UpdateMember(int id, MemberVM vm)
        {
            throw new NotImplementedException();
        }

        public Task<Response<int>> DeleteMember(int id)
        {
            throw new NotImplementedException();
        }
    }
}
