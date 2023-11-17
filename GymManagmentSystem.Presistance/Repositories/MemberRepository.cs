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
            try
            {
               var result= await _context.Set<Member>().FirstOrDefaultAsync(m=>m.Id==id);
               if (result == null)
               {
                   throw new Exception("Something Went wrong !!!");
               }
               return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public async Task<IReadOnlyCollection<Member>> GetAllWithDetails()
        {
            return await _context.Members.Include(c => c.MemberShip)
                .ThenInclude(s => s.Name)
                .ToListAsync();
        }

        public bool IsUserExistedByMobileNum(string mobileNum)
        {
            var member = _context.Members.Where(u=>u.MobileNumber==mobileNum);
            return member.Any();
        }

        public bool IsUserExistedByEmail(string email)
        {
            var member = _context.Members.Where(u => u.Email == email);
            return member.Any();
        }
    }
}
