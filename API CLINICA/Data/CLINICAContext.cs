using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace API_CLINICA.Data
{
    public partial class CLINICAContext : DbContext
    {
        public CLINICAContext()
        {
        }

        public CLINICAContext(DbContextOptions<CLINICAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CitasMedica> CitasMedicas { get; set; } = null!;
        public virtual DbSet<Doctore> Doctores { get; set; } = null!;
        public virtual DbSet<Empleado> Empleados { get; set; } = null!;
        public virtual DbSet<Especialidade> Especialidades { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
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

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Doctore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Colegiatura)
                    .HasMaxLength(50)
                    .HasColumnName("colegiatura");

                entity.Property(e => e.Consultorio)
                    .HasMaxLength(50)
                    .HasColumnName("consultorio");

                entity.Property(e => e.Contraseña).HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .HasColumnName("direccion");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Especialidad).HasMaxLength(100);

                entity.Property(e => e.Experiencia)
                    .HasMaxLength(100)
                    .HasColumnName("experiencia");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FotoPerfil).HasColumnName("fotoPerfil");

                entity.Property(e => e.HoraFin).HasColumnName("horaFin");

                entity.Property(e => e.HoraInicio).HasColumnName("horaInicio");

                entity.Property(e => e.HospitalAfiliado).HasMaxLength(100);

                entity.Property(e => e.Idiomas).HasMaxLength(100);

                entity.Property(e => e.Jornada)
                    .HasMaxLength(50)
                    .HasColumnName("jornada");

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Origen)
                    .HasMaxLength(50)
                    .HasColumnName("origen");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(10)
                    .HasColumnName("sexo");

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

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .HasColumnName("codigo");

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
