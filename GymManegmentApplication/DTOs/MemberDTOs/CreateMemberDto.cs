using GymManegmentApplication.DTOs.MemberShipDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Entity.Member;

namespace GymManegmentApplication.DTOs.MemberDTOs
{
    public class CreateMemberDto : IMemberDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public int Membership_Id { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }
        public string? Avatar { get; set; }
        public Gender Gender { get; set; }
        public string? Instagram { get; set; }
        public string? Telegram { get; set; }
        public string? Facebook { get; set; }
        public string? TikTok { get; set; }
        public string? X { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Brief { get; set; }
    }
}
