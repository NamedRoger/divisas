using Divisas.Models;

namespace Divisas.Services;

public interface IMovimientoService
{
    Task Registrar(Movimiento movimiento);
    Task Cambiar(Dolar dolar);
    Task<List<Movimiento>> Obtener();

}