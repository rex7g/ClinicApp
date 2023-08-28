using API_CLINICA.Data;

namespace API_CLINICA.Repository
{
    public interface IUser
    {
        Task<Usuario> GetAsyncUsuariobyEmail(string email);
        Task<Usuario> GetAsyncUsuariobyTelefono(string telefono);
        Task<IEnumerable<Usuario>> GetAsyncAllUsuario();
        Task<Usuario> GetUsuarioByName(string nombre);
        Task<Usuario> DeleteUsuarioByEmail(string email);
        Task<Usuario> UpdateUsuariobyEmail(string email, Usuario UsuarioActualizado);
        Task<Usuario> CrearUsuarionuevo(Usuario nuevoUsuario);
    }
}
