using System;
using System.Collections.Generic;

namespace API_CLINICA.Data
{
    public partial class HorariosMedico
    {
        public int Id { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
    }
}
