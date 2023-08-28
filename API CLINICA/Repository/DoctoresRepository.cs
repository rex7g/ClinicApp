using API_CLINICA.Data;
using Microsoft.EntityFrameworkCore;

namespace API_CLINICA.Repository
{
    public class DoctoresRepository : IDoctores
    {
        private readonly CLINICAContext _context;

        public DoctoresRepository(CLINICAContext cLINICAContext)
        {
            _context = cLINICAContext;
        }
        public async Task<Doctore> CrearDoctoresnuevo(Doctore nuevoDoctores)
        {
            _context.AddAsync(nuevoDoctores);
            await _context.SaveChangesAsync();

            return nuevoDoctores;
        }

        public async Task<Doctore> DeleteDoctoresByNombre(string nombre)
        {
            var DoctoresEliminado = await _context.Doctores.FirstOrDefaultAsync(e => e.Nombre == nombre);
            if (DoctoresEliminado != null)
            {
                _context.Doctores.Remove(DoctoresEliminado);
                await _context.SaveChangesAsync();
            }
            return DoctoresEliminado;

        }

        public async Task<IEnumerable<Doctore>> GetAsyncAllDoctores()
        {
            var listaDoctores = await _context.Doctores.ToListAsync();
            return listaDoctores;
        }


        public async Task<IEnumerable<Doctore>> GetasyncDoctorbyEspecialidad(string especialidad)
        {
            var doctoresEspecialidad = await _context.Doctores.Where(e => e.Especialidad == especialidad) .ToListAsync();
            return doctoresEspecialidad;

        }

        public async Task<Doctore> GetDoctoresByName(string nombre)
        {
            var DoctoresPorNombre = await _context.Doctores.FirstOrDefaultAsync(e => e.Nombre == nombre);
            return DoctoresPorNombre;
        }

        public async Task<Doctore> UpdateDoctoresbyNombre(string nombre, Doctore DoctoresActualizado)
        {
            var Doctor = await _context.Doctores.FirstOrDefaultAsync(e => e.Nombre == nombre);

            if (Doctor != null)
            {
                Doctor.Nombre = DoctoresActualizado.Nombre;
                Doctor.Apellido = DoctoresActualizado.Apellido;
                Doctor.Especialidad = DoctoresActualizado.Especialidad;
                Doctor.Email = DoctoresActualizado.Email;
                Doctor.Telefono = DoctoresActualizado.Telefono;
                Doctor.Contraseña = DoctoresActualizado.Contraseña;
                // Actualiza otros campos según sea necesario

                _context.Doctores.Update(Doctor);
                await _context.SaveChangesAsync();
            }

            return Doctor;
        }
    }
}
