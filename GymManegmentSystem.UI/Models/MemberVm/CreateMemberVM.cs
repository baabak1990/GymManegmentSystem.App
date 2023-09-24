using System.ComponentModel.DataAnnotations;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;

namespace GymManegmentSystem.UI.Models.MemberVm
{
    public class CreateMemberVM
    {
        [Required(ErrorMessage = "FirstName Is Required !!! ")]
        [MaxLength(150,ErrorMessage = "Name Can not be more than 150 Character !!!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "LastName Is Required !!! ")]
        [MaxLength(150, ErrorMessage = "LastName Can not be more than 150 Character !!!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Birthdate Is Required !!!")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Phone Number Is Required !!! ")]
        [RegularExpression("^(\\+98|0)?9\\d{9}$")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "Please Choose Your Membership Type")]
        public int Membership_Id { get; set; }
        public bool IsValid { get; set; }
        public bool IsPresent { get; set; }
    }

    public class MemberVM : CreateMemberVM
    {
        [Required(ErrorMessage = "Id Is Required !!!")]
        public int Id { get; set; }
    }
}
