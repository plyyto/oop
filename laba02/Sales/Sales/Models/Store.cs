using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Store
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(80)]
        public string? Name { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
