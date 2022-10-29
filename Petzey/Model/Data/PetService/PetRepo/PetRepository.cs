using Petzey.Model.Entities;

namespace Petzey.Model.Data.PetService.PetOwnerRepo
{
    public class PetRepository : IPetRepository
    {
        PetzeyDbContext db = new PetzeyDbContext();
        public void AddPet(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();
        }

        public Pet GetPet(int id)
        {
            return db.Pets.Find(id);
        }

        public void DeletePet(Pet pet)
        {
            db.Pets.Remove(pet);
        }

        public void UpdatePet(Pet pet)
        {
            db.Entry(pet).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
