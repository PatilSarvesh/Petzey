using Petzey.Model.Entities;

namespace Petzey.Model.Data
{
    public class AppointmentCatalogEFRepository : IAppointmentCatalogRepository
    {
        private PetzeyDbContext db =new PetzeyDbContext();
        public List<Appointment> AllAppointment()
        {
            throw new NotImplementedException();
        }

        public void BookAppointment(Appointment appointment)
        {
            db.Appointments.Add(appointment);
            db.SaveChanges();
        }
    }
}
