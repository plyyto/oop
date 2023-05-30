using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    internal class PatientMedicament
    {
        [Required]
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Medicament Medicament { get; set; }
    }
}
