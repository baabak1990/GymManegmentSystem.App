namespace GymManagement.UI.Asp.NetMVC.Models.MemberShipVM
{
    public class CreateMemberShipVM
    {
        public MembershipTypeVm Name { get; set; }
        public int Duration { get; set; }
        public double Price { get; set; }

    }

    public class MemberShipVM:CreateMemberShipVM
    {
        public int Id { get; set; }
    }


    public enum MembershipTypeVm
    {
        Golden,
        Silver,
        Bronze,
        Daily
    }
}
