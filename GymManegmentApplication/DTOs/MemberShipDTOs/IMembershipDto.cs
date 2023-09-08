using GymManegmentSystemDomin.Entity.Membership;

namespace GymManegmentApplication.DTOs.MemberShipDTOs;

public interface IMembershipDto
{
    public MembershipType Name { get; set; }
    public int Duration { get; set; }
    public double Price { get; set; }
}