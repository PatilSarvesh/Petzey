using Microsoft.EntityFrameworkCore;
using Petzey.Model.Entities;

namespace Petzey.Model.Data.AppointmentService.ReceptionistAppointmentRepo
{
    public class ReceptionistAppointmentRepository : IReceptionistAppointmentRepository
    {
        private PetzeyDbContext db = new PetzeyDbContext();

        public void AddAppointment(ReceptionistAppointment Appointment)
            
        {
            db.ReceptionistAppointments.Add(Appointment);
            db.SaveChanges();
        }

        public void DeleteAppointment(ReceptionistAppointment Appointment)
        {
            db.ReceptionistAppointments.Remove(Appointment);

        }

        public List<ReceptionistAppointment> GetAllAppointments()
        {
            //return db.ReceptionistAppointments.ToList();
            return (from app in db.ReceptionistAppointments.Include("Appointment")
                    select app).ToList();
        }

        public ReceptionistAppointment GetAppointment(int id)
        {
            // return db.ReceptionistAppointments.Find(id);
            return (from app in db.ReceptionistAppointments.Include("Appointment")
                    where app.ReceptionistAppointmentId == id
                    select app).FirstOrDefault();
        }

        public List<ReceptionistAppointment> GetAppointmentsByUserId(int id)
        {
            return (from app in db.ReceptionistAppointments.Include("Appointment")
                    where app.Appointment.User == id
                    select app).ToList();
        }

        public void UpdateAppointment(ReceptionistAppointment Appointment)
        {
            db.Entry(Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(Appointment.Appointment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
