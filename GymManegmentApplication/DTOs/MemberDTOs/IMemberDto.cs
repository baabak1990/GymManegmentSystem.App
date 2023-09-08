using GymManegmentApplication.DTOs.MemberShipDTOs;

namespace GymManegmentApplication.DTOs.MemberDTOs;

public interface IMemberDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string MobileNumber { get; set; }
    public MembershipDto MembershipDtos { get; set; }
    public bool IsValid { get; set; }
}