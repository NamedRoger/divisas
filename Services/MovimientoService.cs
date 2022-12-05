using Divisas.Models;
using MongoDB.Driver;

namespace Divisas.Services;

public class MovimientoService : IMovimientoService
{
    private readonly IMongoCollection<Movimiento> collection;

    public MovimientoService(IMongoClient client)
    {
        var database = client.GetDatabase("divisas");
        collection = database.GetCollection<Movimiento>("movimientos");
    }

    public Task Cambiar(Dolar dolar)
    {
        throw new NotImplementedException();
    }

    public async Task Registrar(Movimiento movimiento)
    {
        await collection.InsertOneAsync(movimiento);
    }

    async Task<List<Movimiento>> IMovimientoService.Obtener()
    {
        return await collection.Find(_ => true).ToListAsync();
    }
}