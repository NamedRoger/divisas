using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Divisas.Models;

public class Bitacora 
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public int BitacoraId { get; set; }
    public string TipoMovimiento { get; set; }
    public decimal Monto { get; set; }
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; } = null!;
    public DateTime FechaRegistro { get; set; }

    public Bitacora(int tipoMovimientoId, decimal monto, int usuarioId, string tipoMovimiento)
    {
        Monto = monto;
        UsuarioId = usuarioId;
        FechaRegistro = DateTime.Now;
        TipoMovimiento = tipoMovimiento;
    }
}