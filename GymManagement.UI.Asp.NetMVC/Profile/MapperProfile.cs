using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using GymManagement.UI.Asp.NetMVC.Services.Base;

namespace GymManagement.UI.Asp.NetMVC.Profile
{
    public class MapperProfile:AutoMapper.Profile
    {
        public MapperProfile()
        {
            #region Member

            CreateMap<MemberDto, MemberVm>().ReverseMap();
            CreateMap<CreateMemberDto, CreateMemberVm>().ReverseMap();
            CreateMap<EditMemberDto, MemberVm>().ReverseMap();

            #endregion

        }
    }
}
