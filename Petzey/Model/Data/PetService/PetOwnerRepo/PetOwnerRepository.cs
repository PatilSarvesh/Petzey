using Petzey.Model.Entities;

namespace Petzey.Model.Data.PetService.PetOwnerRepo
{
    public class PetOwnerRepository : IPetOwnerRepository
    {
        PetzeyDbContext db = new PetzeyDbContext();
        public void AddPetOwner(PetOwner petOwner)
        {
            db.PetOwners.Add(petOwner);
            db.SaveChanges();
        }

        public PetOwner GetPetOwner(int id)
        {
            return db.PetOwners.Find(id);
        }

        public void RemovePetOwner(PetOwner petOwner)
        {
            db.PetOwners.Remove(petOwner);
        }

        public void UpdatePetOwner(PetOwner petOwner)
        {
            db.Entry(petOwner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
