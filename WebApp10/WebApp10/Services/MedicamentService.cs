using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp10.Data;
using WebApp10.Models;

namespace WebApp10.Services
{
    public class MedicamentService : IMedicamentService
    {
        private readonly MyDbContext _context;

        public MedicamentService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Medicament> AddMedicamentAsync(Medicament medicament)
        {
            _context.Medicaments.Add(medicament);
            await _context.SaveChangesAsync();
            return medicament;
        }

        public async Task<Medicament> GetMedicamentAsync(int id)
        {
            return await _context.Medicaments.FindAsync(id);
        }

        public async Task<IEnumerable<Medicament>> GetAllMedicamentsAsync()
        {
            return await _context.Medicaments.ToListAsync();
        }

        public async Task<Medicament> UpdateMedicamentAsync(Medicament medicament)
        {
            _context.Medicaments.Update(medicament);
            await _context.SaveChangesAsync();
            return medicament;
        }

        public async Task<bool> DeleteMedicamentAsync(int id)
        {
            var medicament = await _context.Medicaments.FindAsync(id);
            if (medicament == null)
            {
                return false;
            }

            _context.Medicaments.Remove(medicament);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}