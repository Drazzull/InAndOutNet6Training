using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class Expense
    {
        public double Cost { get; set; }

        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; } = string.Empty;
    }
}
