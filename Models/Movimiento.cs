using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Divisas.Models;

public class Movimiento
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id { get; set; }
    public string TipoMovimiento { get; set; } = null!;
    public int CantidadDolares { get; set; }
    public decimal PercioUnitario { get; set; }
    public decimal CostoTotal { get; set; }
    public decimal Pago { get; set; }
    public decimal Cambio { get; set; }
    public DateTime FechaRegistro { get; set; }

    public Movimiento()
    {}

    public Movimiento(
        string tipoMovimiento,
        int cantidadDolares,
        decimal precioUnitario,
        string id)
    {
        TipoMovimiento = tipoMovimiento;
        CantidadDolares = cantidadDolares;
        PercioUnitario = precioUnitario;
        FechaRegistro = DateTime.Now;
        Id = id;
    }

    public Movimiento(
        string tipoMovimiento,
        int cantidadDolares,
        decimal precioUnitario)
    {
        TipoMovimiento = tipoMovimiento;
        CantidadDolares = cantidadDolares;
        PercioUnitario = precioUnitario;
        FechaRegistro = DateTime.Now;
        Id = ObjectId.GenerateNewId().ToString();
    }
}