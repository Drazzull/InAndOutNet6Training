using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class Item
    {
        [Required]
        public string Borrower { get; set; } = string.Empty;

        [Key]
        public int Id { get; set; }

        [DisplayName("Item Name")]
        [Required]
        public string ItemName { get; set; } = string.Empty;

        [Required]
        public string Lender { get; set; } = string.Empty;
    }
}