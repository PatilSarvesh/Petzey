using Petzey.Model.Entities;

namespace Petzey.Model.Data.PetService.PetOwnerRepo
{
    public interface IPetOwnerRepository
    {
        void AddPetOwner(PetOwner petOwner);
        void RemovePetOwner(PetOwner petOwner);
        PetOwner GetPetOwner(int id);
        void UpdatePetOwner(PetOwner petOwner);
    }
}
