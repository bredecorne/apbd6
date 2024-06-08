using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PharmacyApp.Controllers;

[Route("api/[controller]")]
[Controller]
public class DoctorsController : ControllerBase
{
    private PharmacyDbContext _dbContext;

    public DoctorsController(PharmacyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetDoctors()
    {
        var doctors = await _dbContext.Doctors.ToListAsync();
        return Ok(doctors);
    }
}