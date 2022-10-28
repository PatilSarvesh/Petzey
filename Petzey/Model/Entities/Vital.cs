namespace Petzey.Model.Entities
{
    public class Vital
    {
        public int VitalId { get; set; }
        public int HeartRate { get; set; }
        public int Temperature { get; set; }
        public int BP { get; set; }

        public Appointment  Appointment { get; set; }

    }
}