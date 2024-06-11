using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp10.Models;

namespace WebApp10.Services
{
    public interface IDoctorService
    {
        Task<Doctor> AddDoctorAsync(Doctor doctor);
        Task<Doctor> GetDoctorAsync(int id);
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync();
        Task<Doctor> UpdateDoctorAsync(Doctor doctor);
        Task<bool> DeleteDoctorAsync(int id);
    }
}