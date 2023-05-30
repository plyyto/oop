using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(80)]
        public string Email { get; set; }

        public string CreditCardNumber { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
