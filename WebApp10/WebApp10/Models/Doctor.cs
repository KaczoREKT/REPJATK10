using System.ComponentModel.DataAnnotations;

namespace WebApp10.Models
{
    public class Doctor
    {
        [Key]
        public int IdDoctor { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Specialization { get; set; }
    }
}