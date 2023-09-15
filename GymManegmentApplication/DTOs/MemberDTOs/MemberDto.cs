using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentApplication.DTOs.Common;
using GymManegmentApplication.DTOs.MemberShipDTOs;

namespace GymManegmentApplication.DTOs.MemberDTOs
{
    public class MemberDto:BaseEntityDTO, IMemberDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public int MembershipDto_Id { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }
    }
}
