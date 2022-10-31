using Microsoft.EntityFrameworkCore;
using Petzey.Model.Data;
using Petzey.Model.Entities;

namespace Petzey.Model.DataAccess.VetService.DoctorRepo
{
    public class DoctorRepository : IDoctorRepository
    {
        private PetzeyDbContext db = new PetzeyDbContext();
        public void AddDoctor(Doctor doctor)
        {
            db.Doctors.Add(doctor);

          
            db.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            return (from doc in db.Doctors.Include("Clinic")
                    select doc).ToList();
        }

        public Doctor GetDoctor(int id)
        {
            return (from doc in db.Doctors.Include("Clinic")
                    where doc.DoctorId == id
                    select doc).FirstOrDefault();
        }

        public void RemoveDoctor(Doctor doctor)
        {
            db.Doctors.Remove(doctor);
            db.SaveChanges();
        }

        public void UpdateDoctor(Doctor doctor)
        {
            db.Entry(doctor).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.Entry(doctor.Clinic).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
