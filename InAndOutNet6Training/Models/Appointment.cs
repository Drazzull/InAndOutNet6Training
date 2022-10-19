namespace InAndOutNet6Training.Models
{
    public class Appointment
    {
        public Appointment()
        {
            Description = string.Empty;
            Name = string.Empty;
        }

        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
    }
}