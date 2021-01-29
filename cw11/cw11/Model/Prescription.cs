using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace cw11.Model
{
    public class Prescription
    {
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int IdPrescription { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public int IdPatient { get; set; }

        [Required]
        public int IdDoctor { get; set; }
    }
}
