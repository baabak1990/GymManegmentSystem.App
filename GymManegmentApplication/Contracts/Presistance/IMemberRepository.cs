using GymManegmentSystemDomin.Entity.Member;

namespace GymManegmentApplication.Contracts.Presistance;

public interface IMemberRepository:IGenericRepository<Member>
{
    Task<Member> GetWithDetails(int id);
    Task<IReadOnlyCollection<Member>> GetAllWithDetails();
    bool IsUserExistedByMobileNum(string  mobileNum);
}