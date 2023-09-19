using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Models
{
    public class CitasMedicas
    {
        public int Id { get; set; }
        public string? Paciente { get; set; }
        public string? Doctor { get; set; }
        public DateTime? FechaCita { get; set; }
        public string? Especialidad { get; set; }
        public string? Comentarios { get; set; }
        public string? Status { get; set; }
    }
}
