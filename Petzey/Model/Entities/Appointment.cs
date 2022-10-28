namespace Petzey.Model.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForVisit { get; set; }
        public Pet Pet { get; set; }
        public int PetId { get; set; }
        public List<Symptom> Symptom { get; set; }
        public int SymptomId { get; set; }
    }
}
