using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_CLINICA.Data
{
    public partial class CLINICAContext : DbContext
    {     
        public CLINICAContext(DbContextOptions<CLINICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CitasMedica> CitasMedicas { get; set; } 
        public virtual DbSet<Doctore> Doctores { get; set; } 
        public virtual DbSet<Empleado> Empleados { get; set; } 
        public virtual DbSet<Especialidade> Especialidades { get; set; }
        public virtual DbSet<HorariosMedico> HorariosMedicos { get; set; } 
        public virtual DbSet<Usuario> Usuarios { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CitasMedica>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Doctor).HasMaxLength(100);

                entity.Property(e => e.Especialidad).HasMaxLength(100);

                entity.Property(e => e.FechaCita).HasColumnType("datetime");

                entity.Property(e => e.Paciente).HasMaxLength(100);
            });

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Contraseña).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Especialidad).HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(20);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(50)
                    .HasColumnName("codigo");

                entity.Property(e => e.Contraseña).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Puesto).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(20);
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NombreEspecialidad).HasMaxLength(100);
            });

            modelBuilder.Entity<HorariosMedico>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Contraseña).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Telefono).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
