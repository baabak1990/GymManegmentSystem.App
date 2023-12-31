﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Common;
using GymManegmentSystemDomin.Entity.Membership;

namespace GymManegmentSystemDomin.Entity.Member
{
    public class Member : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
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

        #region Relation
        [ForeignKey(nameof(MemberShip))]
        public int memberShip_Id { get; set; }
        public MemberShip MemberShip { get; set; }

        #endregion

    }

    public enum Gender
    {
        Male, Female
    }
    
}
