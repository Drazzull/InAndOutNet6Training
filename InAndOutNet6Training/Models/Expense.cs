using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class Expense
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.00")]
        public double Cost { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}