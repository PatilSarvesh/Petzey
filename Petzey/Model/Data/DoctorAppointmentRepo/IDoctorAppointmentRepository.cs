using Petzey.Model.Entities;

namespace Petzey.Model.Data.DoctorAppointmentRepo
{
    public interface IDoctorAppointmentRepository
    {
        void AddAppointment(DoctorAppointment Appointment);
    }
}
