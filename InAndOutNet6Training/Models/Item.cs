using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class Item
    {
        public string? Borrower { get; set; }

        [Key]
        public int Id { get; set; }

        public string? ItemName { get; set; }

        public string? Lender { get; set; }
    }
}