using ClinicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Services
{
    public interface IHttpService
    {
        Task<IEnumerable<CitasMedicas>> GetCitasMedicas();
        Task<Usuario> GetUsuario(string usuario);
    }
}
