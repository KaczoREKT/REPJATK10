using WebApp10.Data;
using WebApp10.Models;
using WebApp10.Services;

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
        return await _context.Patients.FindAsync(id);
    }
}