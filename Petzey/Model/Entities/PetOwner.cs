namespace Petzey.Model.Entities
{
    public class PetOwner
    {
        public int PetOwnerId { get; set; }
        public string ParentName { get; set; }
        public string Email { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; } 
        public int PetId { get; set; }
    }
}