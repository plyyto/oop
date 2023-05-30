using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    internal class Visitation
    {
        [Required]
        public int VisitationId { get; set; }

        public DateTime Date { get; set; }
        [MaxLength(250)]
        public string? Comments { get; set; }
        public Patient Patient { get; set; }
        public Doctors Doctors { get; set; }
    }
}
