﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    internal class Doctors
    {
        public string DoctorsId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public ICollection<Visitation> Visitations { get; set; }
    }
}
