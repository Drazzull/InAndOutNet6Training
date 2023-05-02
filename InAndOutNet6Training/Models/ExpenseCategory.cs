using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}