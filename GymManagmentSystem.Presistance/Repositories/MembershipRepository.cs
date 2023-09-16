using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagmentSystem.Presistance.Context;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentSystemDomin.Entity.Membership;

namespace GymManagmentSystem.Presistance.Repositories
{
    public class MembershipRepository:GenericRepository<MemberShip>,IMemberShipRepository
    {
        public MembershipRepository(GymManagementDbContext context) : base(context)
        {
        }
    }
}
