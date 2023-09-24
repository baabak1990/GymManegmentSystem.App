using GymManegmentSystem.UI.Models.MemberVm;
using GymManegmentSystem.UI.Services.Base;

namespace GymManegmentSystem.UI.MappingProfile
{
    public class MappingProfile:AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMemberDto, CreateMemberVM>().ReverseMap();
            CreateMap<MemberDto, MemberVM>().ReverseMap();
        }
    }
}
