namespace Petzey.Model.Entities
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public DateTime Date { get; set; }
        public Medicine Medicine { get; set; }
        public int MedicineId { get; set; }
    }
}