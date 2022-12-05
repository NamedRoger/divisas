using Divisas.Models;
using Divisas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Divisas.Controllers;

[ApiController]
[Route("[controller]")]
public class MovimientoController : ControllerBase
{
    private readonly IMovimientoService service;
    public MovimientoController(IMovimientoService service)
    {
        this.service = service;
    }

    
    [HttpPost]
    public async Task<IActionResult> RegistarMovimiento([FromBody] Movimiento model)
    {
        await service.Registrar(model);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> CambiarMonto([FromBody] Dolar model)
    {
        await service.Cambiar(model);
        return Ok();
    }
    
    [HttpGet]
    public async Task <IActionResult> ObtenerMovimientos()
    {
        var movimientos = await service.Obtener();
        return Ok(movimientos);
    }
}