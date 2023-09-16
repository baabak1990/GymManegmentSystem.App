using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem.Presistance.Context;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentSystemDomin.Entity.Member;

namespace GymManagmentSystem.Presistance.Repositories
{
    internal class MemberRepository:GenericRepository<Member>,IMemberRepository
    {
        public MemberRepository(GymManagementDbContext context) : base(context)
        {

        }

    }
}
