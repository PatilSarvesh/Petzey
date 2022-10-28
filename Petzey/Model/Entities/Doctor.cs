namespace Petzey.Model.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public int NPINumber { get; set; }
        public string Speciality { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public Clinic Clinic { get; set; }
        public int ClinicId { get; set; }   

    }
}
