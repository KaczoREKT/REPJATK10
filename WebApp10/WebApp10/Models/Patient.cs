using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp10.Models
{
    public class Patient
    {
        [Key]
        public int IdPatient { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }
    }
}