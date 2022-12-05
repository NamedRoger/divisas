using Microsoft.AspNetCore.Mvc;

namespace Divisas.Controllers;

[ApiController]
[Route("[controller]")]
public class BitacoraController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Bitacora()
    {
        return Ok();
    }
}