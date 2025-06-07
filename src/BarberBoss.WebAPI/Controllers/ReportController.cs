using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReportController : ControllerBase
{
    [HttpPost("{type}/{resource}")]
    public IActionResult Get(string type, string resource)
    {
        throw new NotImplementedException();
    }
}
