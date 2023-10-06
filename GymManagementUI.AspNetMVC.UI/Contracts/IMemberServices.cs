using GymManagementUI.AspNetMVC.UI.Models.Member;
using GymManagementUI.AspNetMVC.UI.Services.Base;

namespace GymManagementUI.AspNetMVC.UI.Contracts;

public interface IMemberServices
{
	Task<List<MemberVm>> GetMembersAsync();
	Task<MemberVm> GetMemberAsync(int Id);
	Task<Response<int>> CreateMember(CreateMemberVm memberVm); 
	Task UpdateMember(MemberVm memberVm);
	Task DeleteMember(MemberVm memberVm);
}