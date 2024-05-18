using Microsoft.EntityFrameworkCore;

namespace Trabajos.Data
{
    public class MuebleriaDBContext : DbContext
    {
        public MuebleriaDBContext(DbContextOptions<MuebleriaDBContext> options) : base(options)
        {
        }

        public DbSet<Compras> Compras { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
    }
}
