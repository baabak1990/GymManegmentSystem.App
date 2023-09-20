using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Entity.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Presistance.Configuration.Entity
{
    public class MembershipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasData(new List<MemberShip>()
            {
                new MemberShip()
                {
                    Id = 1,
                    Duration = 12,
                    Price = 25000,
                    CreateDate = DateTime.Now,
                    Name = MembershipType.Bronze,
                },
                new MemberShip()
                {
                    Id = 2,
                    Duration = 15,
                    Price = 30000,
                    CreateDate = DateTime.Now,
                    Name = MembershipType.Silver
                },
                new MemberShip()
                {
                    Id = 3,
                    Duration = 20,
                    Price = 35000,
                    CreateDate = DateTime.Now,
                    Name = MembershipType.Golden
                },
                new MemberShip()
                {
                    Id = 4,
                    Duration = 1,
                    Price =1000 ,
                    CreateDate = DateTime.Now,
                    Name = MembershipType.Daily
                }
            });
        }
    }
}
