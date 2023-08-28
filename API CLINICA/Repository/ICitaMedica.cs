using API_CLINICA.Data;

namespace API_CLINICA.Repository
{
    public interface ICitaMedica
    {
        Task<CitasMedica> GetAsyncCitasMedica(string Id);
        Task<IEnumerable<CitasMedica>> GetAsyncAllCitasMedica();
        Task<IEnumerable<CitasMedica>> GetAsyncCitasMedicabyEspecialidad(string especialidad);
        Task<CitasMedica> GetCitasMedicaByPaciente(string paciente);
        Task<CitasMedica> GetCitasMedicaByDoctor(string doctor);
        Task<IEnumerable<CitasMedica>> GetCitasMedicaByStatus(string Status);
        Task<CitasMedica> DeleteCitasMedica(string paciente);
        Task<CitasMedica> UpdateCitasMedica(string paciente, CitasMedica CitasMedicaActualizada);
        Task<CitasMedica> CrearNuevaCita(CitasMedica nuevaCita);
    }
}
