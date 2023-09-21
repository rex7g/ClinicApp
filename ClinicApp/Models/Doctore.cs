using System;
using System.Collections.Generic;

namespace API_CLINICA.Data
{
    public partial class Doctore
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Especialidad { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Contraseña { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Consultorio { get; set; }
        public string? Experiencia { get; set; }
        public string? Direccion { get; set; }
        public string? Origen { get; set; }
        public byte[]? FotoPerfil { get; set; }
        public string? Sexo { get; set; }
        public string? Colegiatura { get; set; }
        public int? Edad { get; set; }
        public string? Idiomas { get; set; }
        public string? HospitalAfiliado { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public string? Jornada { get; set; }
    }
}
