using GymManagement.UI.Asp.NetMVC.Models.MemberShipVM;
using System.ComponentModel.DataAnnotations;

namespace GymManagement.UI.Asp.NetMVC.Models.MemberVM
{
    public class CreateMemberVm
    {
        [Required(ErrorMessage = "Name Is Required !")]
        [MaxLength(150,ErrorMessage = "Please Use lesser than 150 characters")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Is Required !")]
        [MaxLength(150, ErrorMessage = "Please Use lesser than 150 characters")]
        public string LastName { get; set; }

        public int Membership_Id { get; set; }
        public MemberShipVM.MemberShipVM MemberShipVM { get; set; }
        public DateTimeOffset BirthDate { get; set; }

        [Required(ErrorMessage = "Mobile Number Is Required !!!")]
        public string MobileNumber { get; set; }
    }

    public class MemberVm:CreateMemberVm
    {
        public int Id { get; set; }

    }
}
