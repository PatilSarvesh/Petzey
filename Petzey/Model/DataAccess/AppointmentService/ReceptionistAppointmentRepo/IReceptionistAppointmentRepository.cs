using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.AppointmentService.ReceptionistAppointmentRepo
{
    public interface IReceptionistAppointmentRepository
    {
        void AddAppointment(ReceptionistAppointment Appointment);
        List<ReceptionistAppointment> GetAllAppointments();
        List<ReceptionistAppointment> GetAppointmentsByUserId(int id);
        ReceptionistAppointment GetAppointment(int id);
        void UpdateAppointment(ReceptionistAppointment Appointment);
        void DeleteAppointment(ReceptionistAppointment Appointment);
    }
}
