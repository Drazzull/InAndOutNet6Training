using System.ComponentModel.DataAnnotations;

namespace InAndOutNet6Training.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        
        public string? Borrower { get; set; }
    }
}