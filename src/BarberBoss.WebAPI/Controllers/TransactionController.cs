using BarberBoss.Exception;
using Microsoft.AspNetCore.Mvc;

namespace BarberBoss.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] object newTransaction)
    {
        throw new DetailedNotImplementedException();
    }

    [HttpGet]
    public IActionResult FindAll()
    {
        throw new DetailedNotImplementedException();
    }

    [HttpGet("{id}")]
    public IActionResult FindOne([FromRoute] Guid id)
    {
        throw new DetailedNotImplementedException();
    }

    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] Guid id, [FromBody] object updatedTransaction)
    {
        throw new DetailedNotImplementedException();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] Guid id)
    {
        throw new DetailedNotImplementedException();
    }
}
