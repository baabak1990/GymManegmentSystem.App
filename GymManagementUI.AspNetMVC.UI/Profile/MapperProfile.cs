using GymManagementUI.AspNetMVC.UI.Models.Member;
using GymManagementUI.AspNetMVC.UI.Services.Base;

namespace GymManagementUI.AspNetMVC.UI.Profile
{
	public class MapperProfile:AutoMapper.Profile
	{
		public MapperProfile()
		{
			CreateMap<CreateMemberDto, CreateMemberVm>().ReverseMap();
			CreateMap<MemberDto, MemberVm>().ReverseMap();
		}
	}
}
