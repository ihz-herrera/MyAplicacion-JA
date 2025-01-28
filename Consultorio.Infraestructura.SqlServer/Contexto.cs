using Microsoft.EntityFrameworkCore;
using MyAplicacion.Entidades;

namespace MyAplicacion
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto() { 
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; initial catalog=myapplication02; trusted_connection=true; encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //mapear entidad cliente
            modelBuilder.Entity<Cliente>()
                .ToTable("genClientesCat")
                .HasKey(e=> e.Id)               
                ;

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .HasColumnName("Descripcion")
                .HasMaxLength(50);



        }

    }
}
