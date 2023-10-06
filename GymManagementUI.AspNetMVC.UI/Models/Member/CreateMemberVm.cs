using System.ComponentModel.DataAnnotations;

namespace GymManagementUI.AspNetMVC.UI.Models.Member
{
	public class CreateMemberVm
	{
		[Required(ErrorMessage = "name Is required !!!")]
		[MaxLength(150)]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "LastName Is required !!!")]
		[MaxLength(150)]
		public string LastName { get; set; }
		[Required(ErrorMessage = "BirthDate is Required !!!")]
		public DateTime BirthDate { get; set; }
		[Required(ErrorMessage = "MobileNumber Is required !!!")]
		[RegularExpression("^(\\+98|0)?9\\d{9}$\r\n")]
		public string MobileNumber { get; set; }
		public bool IsValid { get; set; }
		public bool IsPresent { get; set; }
		[Required(ErrorMessage = "Please Choose Membership Type")]
		public int memberShip_Id { get; set; }
	}

	public class MemberVm : CreateMemberVm
	{
		public int Id { get; set; }
	}
}
