using GymManagement.UI.Asp.NetMVC.Models.MemberShipVM;
using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using GymManagement.UI.Asp.NetMVC.Services.Base;

namespace GymManagement.UI.Asp.NetMVC.Contracts;

public interface IMembershipServices
{
    Task<List<MembershipVM>> GetMembersAsync();
    Task<MembershipVM> GetMemberAsync(int id);
    Task<Response<int>> CreateMember(CreateMembershipVM vm);
    Task<Response<int>> UpdateMember(int id, MembershipVM vm);
    Task<Response<int>> DeleteMember(int id);
}