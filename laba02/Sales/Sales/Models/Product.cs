using System.ComponentModel.DataAnnotations;

namespace Sales.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }


        [MaxLength(50)]
        public string? Name { get; set; }


        public int Quantity { get; set; }


        public float Price { get; set; }

        [MaxLength(250)]
        public string Description
        {
            get { return Description; }

            set
            {
                if (value == null || value == "")
                {
                    Description = "Nema";
                }
                else
                {
                    Description = value;
                }
            }
        }

        public List<Sale> Sales { get; set; }
    }
}
