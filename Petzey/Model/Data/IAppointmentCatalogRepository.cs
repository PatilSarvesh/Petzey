using Petzey.Model.Entities;

namespace Petzey.Model.Data
{
    public interface IAppointmentCatalogRepository
    {
        void BookAppointment(Appointment appointment);
        List<Appointment> AllAppointment();
    }
}
