using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp10.Services;
using WebApp10.Models;


namespace WebApp10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(Patient patient)
        {
            var createdPatient = await _patientService.AddPatientAsync(patient);
            return CreatedAtAction(nameof(GetPatient), new { id = createdPatient.IdPatient }, createdPatient);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _patientService.GetPatientAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }
    }
}