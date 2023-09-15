using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Common;
using GymManegmentSystemDomin.Entity.Membership;

namespace GymManegmentSystemDomin.Entity.Member
{
    public class Member:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }

        #region Relation
        [ForeignKey(nameof(MemberShip))]
        public int memberShip_Id { get; set; }
        public MemberShip MemberShip { get; set; }

        #endregion

    }
}
