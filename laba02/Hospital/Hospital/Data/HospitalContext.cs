using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data
{
    internal class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
        {
        }

        internal DbSet<Patient> Patients { get; set; }
        internal DbSet<Doctors> Doctors { get; set; }
        internal DbSet<Visitation> Visitations { get; set; }
        internal DbSet<Diagnoset> Diagnosets { get; set; }
        internal DbSet<PatientMedicament> PatientMedicaments { get; set; }
        internal DbSet<Medicament> Medicaments { get; set; }
    }
}
