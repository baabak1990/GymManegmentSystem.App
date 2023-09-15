using GymManegmentApplication.DTOs.MemberShipDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManegmentApplication.DTOs.MemberDTOs
{
    public class CreateMemberDto: IMemberDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public MembershipDto MembershipDtos { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }
    }
}
