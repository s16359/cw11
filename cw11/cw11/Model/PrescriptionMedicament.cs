using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace cw11.Model
{
    public class PrescriptionMedicament
    {
        [Required]
        public int Dose { get; set; }

        [Required]
        [MaxLength(100)]
        public string Details { get; set; }

        public int IdMedicament { get; set; }

        public int IdPrescription { get; set; }
    }
}
