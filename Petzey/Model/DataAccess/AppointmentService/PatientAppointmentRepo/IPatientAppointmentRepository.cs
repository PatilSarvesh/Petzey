using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.AppointmentService.PatientAppointmentRepo
{
    public interface IPatientAppointmentRepository
    {
        void AddAppointment(PatientAppointment Appointment);
        List<PatientAppointment> GetAllAppointments();
        List<PatientAppointment> GetAppointmentsByUserId(int id);
        PatientAppointment GetAppointment(int id);
        void UpdateAppointment(PatientAppointment Appointment);
        void DeleteAppointment(PatientAppointment Appointment);
    }
}
