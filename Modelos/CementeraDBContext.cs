using Microsoft.EntityFrameworkCore;

namespace Modelos
{
    public class CementeraDBContext : DbContext
    {
        public CementeraDBContext(DbContextOptions<CementeraDBContext> options):base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<TipoAplicacion> TipoAplicacion { get; set; }
    }
}
