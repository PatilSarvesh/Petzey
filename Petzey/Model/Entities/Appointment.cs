namespace Petzey.Model.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public string ReasonForVisit { get; set; }
        public int SymptomId { get; set; }
        public int PetId { get; set; }
        //logged in user Id
        public int User { get; set; }
    }
}
