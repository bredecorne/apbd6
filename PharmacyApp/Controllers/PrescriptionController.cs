using Microsoft.AspNetCore.Mvc;
using PharmacyApp.Models;

namespace PharmacyApp.Controllers;

[Route("api/[controller]")]
[Controller]
public class PrescriptionController : ControllerBase
{
    private readonly PharmacyDbContext _dbContext;

    public PrescriptionController(PharmacyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrescription(int idPatient, int idDoctor, int idMedicament, 
        int dose, string details)
    {
        var prescription = new Prescription(
            DateTime.Now,
            DateTime.Now.AddDays(14),
            idPatient,
            idDoctor
        );

        await _dbContext.AddAsync(prescription);
        await _dbContext.SaveChangesAsync();

        var prescriptionMedicament = new PrescriptionMedicament(
            idMedicament,
            prescription.IdPrescription,
            dose,
            details
        );
        
        await _dbContext.AddAsync(prescriptionMedicament);
        await _dbContext.SaveChangesAsync();
        
        return Ok();
    }
}