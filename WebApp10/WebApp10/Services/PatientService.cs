using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp10.Services;
using WebApp10.Data;
using WebApp10.Models;

namespace WebApp10.Services
{
    public class PatientService : IPatientService
    {
        private readonly MyDbContext _context;

        public PatientService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        public async Task<Patient> GetPatientAsync(int id)
        {
            return await _context.Patients.Include(p => p.Prescriptions)
                .ThenInclude(p => p.PrescriptionMedicaments)
                .ThenInclude(pm => pm.Medicament)
                .Include(p => p.Prescriptions)
                .ThenInclude(p => p.Doctor)
                .FirstOrDefaultAsync(p => p.IdPatient == id);
        }

        // Implement other necessary methods
    }
}