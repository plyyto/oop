using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Sale
    {
        [Required]
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public Product Product { get; set; }

        public Store Store { get; set; }

        public DateTime Date { get; set; }
    }
}
