using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Azure.Identity;
using GymManagmentSystem.Presistance.Context;
using GymManegmentApplication.Contracts.Presistance;
using GymManegmentSystemDomin.Entity.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace GymManagmentSystem.Presistance.Repositories
{
    internal class MemberRepository : GenericRepository<Member>, IMemberRepository
    {
        private readonly GymManagementDbContext _context;

        public MemberRepository(GymManagementDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Member> GetWithDetails(int id)
        {
            return await _context.Set<Member>().Include(c => c.MemberShip)
                .FirstOrDefaultAsync(c => c.Id == id);


        }

        public async Task<IReadOnlyCollection<Member>> GetAllWithDetails()
        {
            return await _context.Members.Include(c => c.MemberShip)
                .ToListAsync();
        }
    }
}
