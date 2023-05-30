using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    internal class Diagnoset
    {
        [Required]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? Name { get; set; }
        [MaxLength(250)]
        public string? Comments { get; set; }
        public Patient Patient { get; set; }
    }
}
