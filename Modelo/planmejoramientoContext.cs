using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Nivelacion.Modelo
{
    public partial class planmejoramientoContext : DbContext
    {
        public virtual DbSet<Empleados> Empleados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost; userid=root; Database=planmejoramiento");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.Cedula);

                entity.ToTable("empleados");

                entity.Property(e => e.Cedula).HasColumnName("cedula");

                entity.Property(e => e.Diaspagos)
                    .HasColumnName("diaspagos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Diasvaca)
                    .HasColumnName("diasvaca")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(45);

                entity.Property(e => e.Sueldo)
                    .HasColumnName("sueldo")
                    .HasColumnType("int(11)");
            });
        }
    }
}
