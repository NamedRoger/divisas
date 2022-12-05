using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Divisas.Models;

public class Usuario
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string NombreUsuario { get; set; }
    public string Contra { get; set; }
    public bool Activo { get; set; }
    public DateTime FechaRegistro { get; set; }

    public Usuario(
        string nombre,
        string apellidoPaterno,
        string apellidoMaterno,
        string nombreUsuario,
        string contra
    )
    {
        Nombre = nombre;
        ApellidoPaterno = apellidoPaterno;
        ApellidoMaterno = apellidoMaterno;
        NombreUsuario = nombreUsuario;
        Contra = contra;
        Activo = true;
        FechaRegistro = DateTime.Now;
    }
}