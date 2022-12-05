using Divisas.Models;
using Microsoft.EntityFrameworkCore;

namespace Divisas.Data;

public class DivisasContext : DbContext
{
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Movimiento> Movimientos => Set<Movimiento>();
    public DbSet<Bitacora> Bitacoras => Set<Bitacora>();
    public DivisasContext(DbContextOptions<DivisasContext> options)
        : base(options)
    {
    }
}