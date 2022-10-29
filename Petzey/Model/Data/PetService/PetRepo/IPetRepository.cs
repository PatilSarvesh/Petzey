using Petzey.Model.Entities;

namespace Petzey.Model.Data.PetService.PetOwnerRepo
{
    public interface IPetRepository
    {
        void AddPet(Pet pet);
        void UpdatePet(Pet pet);
        Pet GetPet(int id);
        void DeletePet(Pet pet);
    }
}
