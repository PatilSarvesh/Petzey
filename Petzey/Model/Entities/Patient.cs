namespace Petzey.Model.Entities
{
    public class Patient
    {
        public int PatientId { get; set; }
        public DoctorAppointment DoctorAppointment { get; set; }
        public PatientAppointment PatientAppointment { get; set; }
        public ReceptionistAppointment ReceptionistAppointment { get; set; }
        public Vital Vital { get; set; }
        public int VitalId { get; set; }
        public Test Test { get; set; }
        public int TestId { get; set; }
        public List<Prescription> Prescription { get; set; }
        public int PrescriptionId { get; set; }
    }
}
