using GymManegmentSystem.UI.Models.MemberVm;
using GymManegmentSystem.UI.Services.Base;

namespace GymManegmentSystem.UI.Contracts;

public interface IMemberServices
{
    Task<List<MemberVM>> GetMembers();
    Task<MemberVM> GetMemberWithDetails(int id);
    Task<Response<int>> CreateMember(CreateMemberVM vm);
    Task UpdateMember(MemberVM  vm);
    Task DeleteMember(MemberVM vm);

}