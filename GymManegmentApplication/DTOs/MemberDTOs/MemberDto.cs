using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.Common;
using GymManegmentApplication.DTOs.MemberShipDTOs;
using GymManegmentSystemDomin.Entity.Member;

namespace GymManegmentApplication.DTOs.MemberDTOs
{
    public class MemberDto:BaseEntityDTO, IMemberDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public int Membership_Id { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }
        public string Avatar { get; set; }
        public Gender Gender { get; set; }
    }
}
