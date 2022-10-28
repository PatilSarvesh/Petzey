namespace Petzey.Model.Entities
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public int Days { get; set; }
        public string Description { get; set; }
        public DateTime Time { get; set; }
    }
}