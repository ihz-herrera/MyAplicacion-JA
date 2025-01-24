using Consultorio.Infraestructura.Entidades;
using Microsoft.EntityFrameworkCore;
using MyAplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAplicacion
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }

        public Contexto() { 
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\BaseDatos\\MyAplicacion.db");
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


            modelBuilder.Entity<Doctor>()
                .ToTable("genDoctoresCat")
                .HasKey(e => e.Id)
                ;

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Nombre)
                .HasColumnName("Descripcion")
                .HasMaxLength(50);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Direccion)
                .HasColumnName("Direccion")
                .HasMaxLength(50);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Telefono)
                .HasColumnName("Telefono")
                .HasMaxLength(50);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.Email)
                .HasColumnName("Email")
                .HasMaxLength(50);



        }

    }
}
