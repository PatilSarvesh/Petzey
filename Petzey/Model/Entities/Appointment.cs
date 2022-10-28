namespace Petzey.Model.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForVisit { get; set; }
        public Symptom Symptom { get; set; }
        public int SymptomId { get; set; }

        //logged in user Id
        public string UserName { get; set; }
    }
}
