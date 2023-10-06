using AutoMapper;
using GymManagementUI.AspNetMVC.UI.Contracts;
using GymManagementUI.AspNetMVC.UI.Models.Member;
using GymManagementUI.AspNetMVC.UI.Services.Base;

namespace GymManagementUI.AspNetMVC.UI.Services
{
	public class MemberService:BaseHttpService,IMemberServices
	{
		private readonly ILocalStorageService _localStorageService;
		private readonly IMapper _mapper;
		private new readonly IClient _client;

		public MemberService(IClient client, ILocalStorageService localStorage, ILocalStorageService localStorageService, IMapper mapper) : base(client, localStorage)
		{
			_client = client;
			_localStorageService = localStorageService;
			_mapper = mapper;
		}

		public Task<List<MemberVm>> GetMembersAsync()
		{
			throw new NotImplementedException();
		}

		public Task<MemberVm> GetMemberAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public Task<Response<int>> CreateMember(CreateMemberVm memberVm)
		{
			throw new NotImplementedException();
		}

		public Task UpdateMember(MemberVm memberVm)
		{
			throw new NotImplementedException();
		}

		public Task DeleteMember(MemberVm memberVm)
		{
			throw new NotImplementedException();
		}

		
	}
}
