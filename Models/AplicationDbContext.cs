using Microsoft.EntityFrameworkCore;

namespace FBTarjeta.Models
{
    public class AplicationDbContext : DbContext
    {



        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        //Aqui estamos mapeando el modelo TarjetaCredito con la bd, TarjetaCreditos
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
}
