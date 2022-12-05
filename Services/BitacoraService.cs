using Divisas.Models;
using MongoDB.Driver;

namespace Divisas.Services;

public class BitacoraService : IBitacoraService
{
    private readonly IMongoCollection<Bitacora> collection;
    public BitacoraService(IMongoClient client)
    {
        var database = client.GetDatabase("divisas");
        collection = database.GetCollection<Bitacora>("bitacora");
    }

    public Task Cambiar(Dolar bitacora)
    {
        throw new NotImplementedException();
    }

    public Task<List<Bitacora>> Obtener()
    {
        throw new NotImplementedException();
    }

    public Task Registrar(Bitacora bitacora)
    {
        throw new NotImplementedException();
    }
}