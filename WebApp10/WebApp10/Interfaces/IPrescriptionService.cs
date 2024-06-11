using System.Threading.Tasks;
using WebApp10.Models;

namespace WebApp10.Services
{
    public interface IPrescriptionService
    {
        Task<Prescription> AddPrescriptionAsync(Prescription prescription);
        Task<Prescription> GetPrescriptionAsync(int id);
        // other methods...
    }
}