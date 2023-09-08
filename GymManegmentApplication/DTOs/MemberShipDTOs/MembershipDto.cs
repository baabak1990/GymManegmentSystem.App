using GymManegmentSystemDomin.Entity.Membership;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManegmentApplication.DTOs.MemberShipDTOs
{
    public class MembershipDto: IMembershipDto
    {
        public MembershipType Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }
    }
}
