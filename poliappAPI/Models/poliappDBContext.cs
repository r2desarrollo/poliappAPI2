using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace poliappAPI.Models
{
    public partial class poliappDBContext : DbContext
    {
      

        public virtual DbSet<Pesaje> Pesaje { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }


        public poliappDBContext(DbContextOptions<poliappDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Pesaje>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Evidencia)
                    .HasColumnName("EVIDENCIA")
                    .HasMaxLength(50);

                entity.Property(e => e.Material).HasColumnName("MATERIAL");

                entity.Property(e => e.Pesoneto).HasColumnName("PESONETO");

                entity.Property(e => e.Proveedor).HasColumnName("PROVEEDOR");

                entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");

              
            });

           


            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100);

                entity.Property(e => e.Foto)
                    .HasColumnName("FOTO")
                    .HasMaxLength(50);

                entity.Property(e => e.Nivel).HasColumnName("NIVEL");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(100);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(10);

                entity.Property(e => e.Prol).HasColumnName("PROL");

                entity.Property(e => e.Sucursal).HasColumnName("SUCURSAL");

            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
