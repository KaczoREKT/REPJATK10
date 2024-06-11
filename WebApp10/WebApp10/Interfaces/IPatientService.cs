using System.Threading.Tasks;
using WebApp10.Models;

namespace WebApp10.Services
{
    public interface IPatientService
    {
        Task<Patient> AddPatientAsync(Patient patient);
        Task<Patient> GetPatientAsync(int id);
        // other methods...
    }
}