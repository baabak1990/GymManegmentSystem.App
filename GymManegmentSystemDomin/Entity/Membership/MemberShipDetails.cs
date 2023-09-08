using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Common;

namespace GymManegmentSystemDomin.Entity.Membership
{
    public class MemberShipDetails : BaseEntity
    {
        public Gender Gender { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime LeftTime { get; set; }




        #region Relation
        [ForeignKey(nameof(MemberShip))]
        public int Membership_Id { get; set; }
        public MemberShip MemberShip { get; set; }

        #endregion relation
    }

    public enum Gender
    {
        Male,Female
    }
}
