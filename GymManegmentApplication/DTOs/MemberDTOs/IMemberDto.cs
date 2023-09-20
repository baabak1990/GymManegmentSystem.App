using GymManegmentApplication.DTOs.MemberShipDTOs;

namespace GymManegmentApplication.DTOs.MemberDTOs;

public interface IMemberDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string MobileNumber { get; set; }
    public int Membership_Id { get; set; }
    public bool IsValid { get; set; }
    public bool IsPresent { get; set; }
}