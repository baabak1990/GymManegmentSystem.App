using GymManagement.UI.Asp.NetMVC.Models.MemberShipVM;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GymManagement.UI.Asp.NetMVC.Models.MemberVM
{
    public class CreateMemberVm
    {
        [Required(ErrorMessage = "Name Is Required !")]
        [MaxLength(150, ErrorMessage = "Please Use lesser than 150 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName Is Required !")]
        [MaxLength(150, ErrorMessage = "Please Use lesser than 150 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Membership Is Required !")]
        public int Membership_Id { get; set; }
        public DateTimeOffset BirthDate { get; set; }

        [Required(ErrorMessage = "MobileNumber Is Required !")]
        public string MobileNumber { get; set; }

        public string Avatar { get; set; }
        public IFormFile? UserAvatar { get; set; }

        [Required(ErrorMessage = "Gender Is Required !")]
        public Gender Gender { get; set; }

        public bool IsPresent { get; set; }
        public bool IsValid { get; set; }
        public string? Instagram { get; set; }
        public string? Telegram { get; set; }
        public string? Facebook { get; set; }
        public string? TikTok { get; set; }
        public string? X { get; set; }
        [EmailAddress(ErrorMessage = "Please Use Correct Format of Email Address .Exp :example@gym.com")]
        public string? Email { get; set; }
        public string? Address { get; set; }

        [MaxLength(700,ErrorMessage = "Please use lesser than 700 characters !!!")]
        public string? Brief { get; set; }
    }

    public class MemberVm : CreateMemberVm
    {
        public int Id { get; set; }

    }


    public enum Gender
    {
        Male=1, Female=2, Unknown=3
    }
}
