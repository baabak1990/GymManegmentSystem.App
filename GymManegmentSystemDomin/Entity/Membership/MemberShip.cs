using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Common;

namespace GymManegmentSystemDomin.Entity.Membership
{
    public class MemberShip:BaseEntity
    {
        public MembershipType Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }

        
        #region Relation

        public MemberShipDetails MemberShipDetails { get; set; }

        #endregion relation

    }

    public enum MembershipType
    {
        Golden,
        Silver,
        Bronze,
        Daily
    }
}
