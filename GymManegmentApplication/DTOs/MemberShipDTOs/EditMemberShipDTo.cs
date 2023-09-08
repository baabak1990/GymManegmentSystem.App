using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.Common;
using GymManegmentSystemDomin.Entity.Membership;

namespace GymManegmentApplication.DTOs.MemberShipDTOs
{
    public class EditMemberShipDTo:BaseEntityDTO, IMembershipDto
    {
        public MembershipType Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
    }
}
