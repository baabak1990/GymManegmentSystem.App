using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.MemberDTOs;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using GymManegmentSystemDomin.Entity.Member;
using GymManegmentSystemDomin.Entity.Membership;

namespace GymManegmentApplication.Profile
{
    public class MappingProfile:AutoMapper.Profile
    {
        public MappingProfile()
        {
            #region Membership

            CreateMap<MemberShip, CreateMembershipDTO>().ReverseMap();
            CreateMap<MemberShip, EditMemberShipDTo>().ReverseMap();
            CreateMap<MemberShip, MembershipDto>().ReverseMap();


            #endregion
            #region Member

            CreateMap<Member, CreateMemberDto>().ReverseMap();
            CreateMap<Member, EditMemberDto>().ReverseMap();
            CreateMap<Member, MemberDto>().ReverseMap();

            #endregion
        }
    }
}
