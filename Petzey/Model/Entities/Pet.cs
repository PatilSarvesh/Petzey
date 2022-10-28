namespace Petzey.Model.Entities
{
    public class Pet
    {
        public int PetId { get; set; }
        public string petName { get; set; }
        public string species { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }

        public Symptom Symptom { get; set; }
        public int SymptomId { get; set; }
    }
}