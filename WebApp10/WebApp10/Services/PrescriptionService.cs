using Microsoft.EntityFrameworkCore;
using WebApp10.Data;
using WebApp10.Models;

namespace WebApp10.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private readonly MyDbContext _context;

        public PrescriptionService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Prescription> AddPrescriptionAsync(Prescription prescription)
        {
            if (prescription.PrescriptionMedicaments.Count > 10)
            {
                throw new InvalidOperationException("Prescription cannot contain more than 10 medicaments.");
            }

            if (prescription.DueDate < prescription.Date)
            {
                throw new InvalidOperationException("DueDate must be greater than or equal to Date.");
            }

            _context.Prescriptions.Add(prescription);
            await _context.SaveChangesAsync();
            return prescription;
        }

        public async Task<Prescription> GetPrescriptionAsync(int id)
        {
            return await _context.Prescriptions
                .Include(p => p.PrescriptionMedicaments)
                .ThenInclude(pm => pm.Medicament)
                .Include(p => p.Doctor)
                .FirstOrDefaultAsync(p => p.IdPrescription == id);
        }

        // Implement other necessary methods
    }
}