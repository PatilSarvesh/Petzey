using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.AppointmentService.DoctorAppointmentRepo
{
    public interface IDoctorAppointmentRepository
    {
        void AddAppointment(DoctorAppointment Appointment);
        List<DoctorAppointment> GetAllAppointments();
        List<DoctorAppointment> GetAppointmentsByUserId(int id);
        DoctorAppointment GetAppointment(int id);
        void UpdateAppointment(DoctorAppointment Appointment);
        void DeleteAppointment(DoctorAppointment Appointment);
    }
}
