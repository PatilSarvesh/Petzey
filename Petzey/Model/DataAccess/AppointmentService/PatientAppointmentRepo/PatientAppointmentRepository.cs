using Microsoft.EntityFrameworkCore;
using Petzey.Model.Data;
using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.AppointmentService.PatientAppointmentRepo
{
    public class PatientAppointmentRepository : IPatientAppointmentRepository
    {
        private PetzeyDbContext db = new PetzeyDbContext();
        public void AddAppointment(PatientAppointment Appointment)
        {
            db.PatientAppointments.Add(Appointment);
            db.SaveChanges();
        }

        public void DeleteAppointment(PatientAppointment Appointment)
        {
            db.PatientAppointments.Remove(Appointment);
        }

        public List<PatientAppointment> GetAllAppointments()
        {
            return (from app in db.PatientAppointments.Include("Appointment")
                    select app).ToList();
        }

        public PatientAppointment GetAppointment(int id)
        {
            return(from app in db.PatientAppointments.Include("Appointment")
                   where app.PatientAppointmentId == id
                   select app).FirstOrDefault();
        }

        public List<PatientAppointment> GetAppointmentsByUserId(int id)
        {
            return (from app in db.PatientAppointments.Include("Appointment")
                    where app.Appointment.User == id
                    select app).ToList();
        }

        public void UpdateAppointment(PatientAppointment Appointment)
        {
            db.Entry(Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(Appointment.Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
