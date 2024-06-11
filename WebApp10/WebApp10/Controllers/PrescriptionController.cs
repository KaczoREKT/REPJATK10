using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp10.Services;
using WebApp10.Models;

namespace WebApp10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrescriptionController : ControllerBase
    {
        private readonly IPrescriptionService _prescriptionService;

        public PrescriptionController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPrescription(Prescription prescription)
        {
            try
            {
                var createdPrescription = await _prescriptionService.AddPrescriptionAsync(prescription);
                return CreatedAtAction(nameof(GetPrescription), new { id = createdPrescription.IdPrescription }, createdPrescription);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrescription(int id)
        {
            var prescription = await _prescriptionService.GetPrescriptionAsync(id);
            if (prescription == null)
            {
                return NotFound();
            }
            return Ok(prescription);
        }
    }
}