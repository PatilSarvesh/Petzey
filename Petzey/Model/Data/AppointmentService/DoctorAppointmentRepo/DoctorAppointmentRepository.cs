using Microsoft.EntityFrameworkCore;
using Petzey.Model.Entities;

namespace Petzey.Model.Data.AppointmentService.DoctorAppointmentRepo
{
    public class DoctorAppointmentRepository : IDoctorAppointmentRepository
    {
        private PetzeyDbContext db =new PetzeyDbContext();

        public void AddAppointment(DoctorAppointment Appointment)
        {
            db.DoctorAppointments.Add(Appointment);
            db.SaveChanges();
        }

        public void DeleteAppointment(DoctorAppointment Appointment)
        {
            db.DoctorAppointments.Remove(Appointment);
        }

        public List<DoctorAppointment> GetAllAppointments()
        {
            //return db.DoctorAppointments.ToList();
            return (from app in db.DoctorAppointments.Include("Appointment")
                    select app).ToList();
        }

        public DoctorAppointment GetAppointment(int id)
        {
            //return db.DoctorAppointments.Find(id);
            return (from app in db.DoctorAppointments.Include("Appointment")
                    where app.DoctorAppointmentId == id
                    select app).FirstOrDefault();
        }

        public List<DoctorAppointment> GetAppointmentsByUserId(int id)
        {
            return (from app in db.DoctorAppointments.Include("Appointment")
                    where app.Appointment.User == id
                    select app).ToList();
        }

        public void UpdateAppointment(DoctorAppointment Appointment)
        {
            db.Entry(Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(Appointment.Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
