﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Entity.Member;
using GymManegmentSystemDomin.Entity.Membership;
using Microsoft.EntityFrameworkCore;

namespace GymManagmentSystem.Presistance.Context
{
    public class GymManagementDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public GymManagementDbContext(DbContextOptions<GymManagementDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


        #region DbSets

        public DbSet<Member> Members { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }

        #endregion
    }
}
