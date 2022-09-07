using System.ComponentModel.DataAnnotations;

namespace Blazor_Transaction_App.Models
{
    public class TransactionModel
    {
        [Key]
        public int Id { get; set; } 
        public string? Description { get; set; }  

        [Required]
        [Range(0,100000)]
        public decimal Credit { get; set; }

        [Required]
        [Range(0, 100000)]
        public decimal Debit { get; set; }
        public decimal Balance { get; set; }  
        public DateTime Date { get; set; }  
    }
}
