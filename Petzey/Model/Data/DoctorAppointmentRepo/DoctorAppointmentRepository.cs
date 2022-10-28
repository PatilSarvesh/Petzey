using Petzey.Model.Entities;

namespace Petzey.Model.Data.DoctorAppointmentRepo
{
    public class DoctorAppointmentRepository : IDoctorAppointmentRepository
    {
        private PetzeyDbContext db =new PetzeyDbContext();

        public void AddAppointment(DoctorAppointment Appointment)
        {
            db.DoctorAppointments.Add(Appointment);
            db.SaveChanges();
        }
    }
}
