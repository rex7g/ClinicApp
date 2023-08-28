﻿using API_CLINICA.Data;

namespace API_CLINICA.Repository
{
    public interface IUser
    {
        //crear el campo usuario dentro de la tabla usuario
        Task<Usuario> GetAsyncUsuariobyEmail(string email);
        Task<Usuario> GetAsyncUsuariobyTelefono(string telefono);
        Task<IEnumerable<Usuario>> GetAsyncAllUsuario();
        Task<Usuario> GetUsuarioByName(string nombre);
        Task<Usuario> DeleteUsuarioByEmail(string email);
        Task<Usuario> UpdateUsuariobyEmail(string email, Usuario UsuarioActualizado);
        Task<Usuario> CrearUsuarionuevo(Usuario nuevoUsuario);
        //Task<Usuario> CreateNombreUsuario(string nombre,string apellido);
    }
}
