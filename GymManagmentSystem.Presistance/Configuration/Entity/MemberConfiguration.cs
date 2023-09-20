using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManegmentSystemDomin.Entity.Member;
using GymManegmentSystemDomin.Entity.Membership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagmentSystem.Presistance.Configuration.Entity
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasData(new List<Member>()
            {
                new Member()
                {
                    Id = 1,
                    BirthDate = new DateTime(2000,02,08),
                    CreateDate = DateTime.Now,
                    IsValid = true,
                    FirstName = "Baabak",
                    LastName = "Aghaei",
                    MobileNumber = "09125595423",
                    IsPresent = true,
                    memberShip_Id = 1,
                },
                new Member()
                {
                    Id = 2,
                    BirthDate = new DateTime(1990 , 05 , 02),
                    CreateDate = DateTime.Now,
                    IsValid = true,
                    FirstName = "Leila",
                    LastName = "Aghaei",
                    MobileNumber = "09125595281",
                    IsPresent = true,
                    memberShip_Id = 2,
                }

               });
        }
    }
}
