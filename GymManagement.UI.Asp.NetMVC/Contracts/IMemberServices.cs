using GymManagement.UI.Asp.NetMVC.Models.MemberVM;
using GymManagement.UI.Asp.NetMVC.Services.Base;

namespace GymManagement.UI.Asp.NetMVC.Contracts
{
    public interface IMemberServices
    {
        Task<List<MemberVm>> GetMembersAsync();
        Task<MemberVm> GetMemberAsync(int id);
        Task<Response<int>> CreateMember(CreateMemberVm  vm);
        Task<Response<int>> UpdateMember(int id,MemberVm  vm);
        Task<Response<int>> DeleteMember(int id);
    }
}
