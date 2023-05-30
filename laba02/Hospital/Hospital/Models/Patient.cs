using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    internal class Patient
    {
        [Required]
        public int PatientId { get; set; }
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [MaxLength(50)]
        public string? LastName { get; set; }
        [MaxLength(250)]
        public string? Address { get; set; }
        [MaxLength(80)]
        public string? Email { get; set; }

        public bool? HasInsurance { get; set; }
        public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}
