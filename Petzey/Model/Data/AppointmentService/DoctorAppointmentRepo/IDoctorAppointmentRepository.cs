using Petzey.Model.Entities;

namespace Petzey.Model.Data.AppointmentService.DoctorAppointmentRepo
{
    public interface IDoctorAppointmentRepository
    {
        void AddAppointment(DoctorAppointment Appointment);
        List<DoctorAppointment> GetAllAppointments();
        DoctorAppointment GetAppointment(int id);
        void UpdateAppointment(DoctorAppointment Appointment);
        void DeleteAppointment(DoctorAppointment Appointment);
    }
}
