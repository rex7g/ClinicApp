using API_CLINICA.Data;
using API_CLINICA.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CLINICA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctoresController : Controller
    {
        private readonly IDoctores _DoctoresRepository;
        private readonly CLINICAContext _context;

        public DoctoresController(IDoctores doctores, CLINICAContext context)
        {
            _DoctoresRepository = doctores;
            _context = context;
        }
        [HttpGet("ListaDoctores")]
        public async Task<IActionResult> GetDoctores()
        {
            var Doctoress = await _DoctoresRepository.GetAsyncAllDoctores();
            return Ok(Doctoress);
        }
        [HttpGet("BuscarDoctoresporEspecialidad")]
        public async Task<IActionResult> GetDoctores(string especialidad)
        {
            var Doctoress = await _DoctoresRepository.GetasyncDoctorbyEspecialidad(especialidad);
            return Ok(Doctoress);
        }
        [HttpGet("BuscarDoctoresporNombre")]
        public async Task<IActionResult> GetDoctoresporNombre(string nombre)
        {
            var Doctoress = await _DoctoresRepository.GetDoctoresByName(nombre);
            return Ok(Doctoress);
        }
        [HttpPut("ActualizarDoctores")]
        public async Task<IActionResult> UpdateDoctoresbyCodigo(string nombre, Doctore DoctoresActualizado)
        {
            var Doctores = await _DoctoresRepository.UpdateDoctoresbyNombre(nombre, DoctoresActualizado);
            return Ok(Doctores);
        }
        [HttpDelete("DeleteDoctores")]
        public async Task<IActionResult> DeleteDoctoresbycodigo(string nombre)
        {
            var Doctores = await _DoctoresRepository.DeleteDoctoresByNombre(nombre);
            return Ok(Doctores);
        }
        [HttpPost("CrearDoctores")]
        public async Task<IActionResult> CrearDoctores([FromBody] Doctore nuevoDoctores)
        {
            var DoctoresNuevo = await _DoctoresRepository.CrearDoctoresnuevo(nuevoDoctores);
            return Ok(DoctoresNuevo);
        }
    }
}
