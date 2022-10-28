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

        public List<DoctorAppointment> GetAllAppointments()
        {
            return db.DoctorAppointments.ToList();
        }

        public DoctorAppointment GetAppointment(int id)
        {
            DoctorAppointment appointment = db.DoctorAppointments.Find(id);
            appointment.Appointment = db.Appointments.Find(appointment.AppointmentId);
            return appointment;
        }
    }
}
