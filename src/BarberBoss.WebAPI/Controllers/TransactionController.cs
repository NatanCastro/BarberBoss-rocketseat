using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] object newTransaction)
    {
        throw new NotImplementedException();
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public IActionResult FindOne([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] Guid id, [FromBody] object updatedTransaction)
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        throw new NotImplementedException();
    }

    [HttpGet("report/{type}")]
    public IActionResult Report([FromRoute] string type)
    {
        throw new NotImplementedException();
    }
}
