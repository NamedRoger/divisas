using Divisas.Models;

namespace Divisas.Services;

public interface IBitacoraService
{
    Task Registrar(Bitacora bitacora);
    Task Cambiar(Dolar dolar);
    Task<List<Bitacora>> Obtener();

}