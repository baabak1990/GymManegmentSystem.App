namespace GymManagement.UI.Asp.NetMVC.Models.MemberShipVM
{
    public class CreateMembershipVM
    {
        public MembershipTypeVm Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }

    }

    public class MembershipVM:CreateMembershipVM
    {
        public int Id { get; set; }
    }


    public enum MembershipTypeVm
    {
        Golden=1,
        Silver=2,
        Bronze=4,
        Daily=6
    }
}
