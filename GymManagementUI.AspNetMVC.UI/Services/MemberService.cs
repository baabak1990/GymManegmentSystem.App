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

		public async Task<List<MemberVm>> GetMembersAsync()
		{
			var members = await _client.MemberAllAsync();
			return _mapper.Map<List<MemberVm>>(members);
		}

		public async Task<MemberVm> GetMemberAsync(int Id)
		{
			var member = await _client.MemberGETAsync(Id);
			return _mapper.Map<MemberVm>(member);
		}

		public async Task<Response<int>> CreateMember(CreateMemberVm memberVm)
		{
			throw new NotImplementedException();
		}

		public async Task<Response<int>> UpdateMember(int id,MemberVm memberVm)
		{
			throw new NotImplementedException();
		}

		public async Task<Response<int>> DeleteMember(int id)
		{
			throw new NotImplementedException();
		}

		
	}
}
