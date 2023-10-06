using GymManagementUI.AspNetMVC.UI.Models.Member;
using GymManagementUI.AspNetMVC.UI.Services.Base;

namespace GymManagementUI.AspNetMVC.UI.Contracts;

public interface IMemberServices
{
	Task<List<MemberVm>> GetMembersAsync();
	Task<MemberVm> GetMemberAsync(int Id);
	Task<Response<int>> CreateMember(CreateMemberVm memberVm); 
	Task<Response<int>> UpdateMember(int id, MemberVm memberVm);
	Task<Response<int>> DeleteMember(int id);
}