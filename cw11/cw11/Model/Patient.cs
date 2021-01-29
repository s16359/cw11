using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace cw11.Model
{
    public class Patient
    {
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public int IdPatient { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
    }
}
