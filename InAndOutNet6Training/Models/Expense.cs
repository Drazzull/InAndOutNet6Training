using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InAndOutNet6Training.Models
{
    public class Expense
    {
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Cost must be greater than 0.00")]
        public double Cost { get; set; }

        [ForeignKey(nameof(ExpenseCategoryId))]
        public virtual ExpenseCategory? ExpenseCategory { get; set; }

        [DisplayName("Expense Category")]
        public int? ExpenseCategoryId { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}