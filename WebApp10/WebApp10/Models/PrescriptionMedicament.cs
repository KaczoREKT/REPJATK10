using System.ComponentModel.DataAnnotations;

namespace WebApp10.Models
{
    public class PrescriptionMedicament
    {
        [Key]
        public int IdPrescriptionMedicament { get; set; }

        [Required]
        public int IdPrescription { get; set; }
        public Prescription Prescription { get; set; }

        [Required]
        public int IdMedicament { get; set; }
        public Medicament Medicament { get; set; }

        [Required]
        public int Dose { get; set; }

        public string Details { get; set; }
    }
}