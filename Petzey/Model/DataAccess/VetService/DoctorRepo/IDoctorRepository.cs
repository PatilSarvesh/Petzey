using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.VetService.DoctorRepo
{
    public interface IDoctorRepository
    {
        void AddDoctor(Doctor doctor);
        void RemoveDoctor(Doctor doctor);
        Doctor GetDoctor(int id);
        List<Doctor> GetAllDoctors();
        void UpdateDoctor(Doctor doctor);
    }
}
