using API_CLINICA.Data;
using API_CLINICA.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_CLINICA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitaMedicaController : Controller
    {
        private readonly ICitaMedica _citaMedicaRepository;
        private readonly CLINICAContext _context;

        public CitaMedicaController(ICitaMedica citamedica, CLINICAContext context)
        {
            _citaMedicaRepository = citamedica;
            _context = context;
        }
        [HttpGet("ListaCitasMedicas")]
        public async Task<IActionResult> GetCitasMedicas()
        {
            var Doctoress = await _citaMedicaRepository.GetAsyncAllCitasMedica();
            return Json(Doctoress);
        }
       
        [HttpGet("BuscarCitaporStatus")]
        public async Task<IActionResult> GetCitasMedicaByStatus(string paciente)
        {
            var Doctoress = await _citaMedicaRepository.GetCitasMedicaByStatus(paciente);
            return Json(Doctoress);
        }
        [HttpGet("BuscarCitaporDoctor")]
        public async Task<IActionResult> GetCitasMedicaByDoctor(string doctor)
        {
            var cita = await _citaMedicaRepository.GetCitasMedicaByDoctor(doctor);
            return Json(cita);
        }
        [HttpPut("ActualizarCita")]
        public async Task<IActionResult> UpdateCitaMedicabyPaciente(string paciente, CitasMedica citas)
        {
            var cita = await _citaMedicaRepository.UpdateCitasMedica(paciente, citas);
            return Json(cita);
        }
        [HttpDelete("DeleteCita")]
        public async Task<IActionResult> DeleteCitasMedicas(string paciente)
        {
            var Doctores = await _citaMedicaRepository.DeleteCitasMedica(paciente);
            return Json(Doctores);
        }
        [HttpPost("CrearCita")]
        public async Task<IActionResult> CrearCitaMedica([FromBody] CitasMedica nuevaCita)
        {
            var CitaNueva = await _citaMedicaRepository.CrearNuevaCita(nuevaCita);
            return Json(CitaNueva);
        }
        [HttpGet("CantidadCitaMedica")]
        public async Task<IActionResult>GetCantidaCitasMedicas()
        {

            var NumeroCitamedica = await _citaMedicaRepository.CantidadCitasmedicas();
            return Json(NumeroCitamedica); 
        } 

    }
}
