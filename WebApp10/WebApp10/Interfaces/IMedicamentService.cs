using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp10.Models;

namespace WebApp10.Services
{
    public interface IMedicamentService
    {
        Task<Medicament> AddMedicamentAsync(Medicament medicament);
        Task<Medicament> GetMedicamentAsync(int id);
        Task<IEnumerable<Medicament>> GetAllMedicamentsAsync();
        Task<Medicament> UpdateMedicamentAsync(Medicament medicament);
        Task<bool> DeleteMedicamentAsync(int id);
    }
}