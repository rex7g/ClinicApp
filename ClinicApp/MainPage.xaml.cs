using ClinicApp.Services;
using Newtonsoft.Json;

namespace ClinicApp;

public partial class MainPage : ContentPage
{

    private readonly httpServices _httpServices;

	public MainPage(httpServices httpServices)
	{
		InitializeComponent();
        _httpServices = httpServices;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = TxtUsuario.Text;
        string contrasena = TxtPassword.Text;

        try
        {
            // Llama al método del repositorio para obtener el usuario por nombre.
            var usuarioEncontrado =  await _httpServices.GetUsuario(usuario);
           

            if (usuarioEncontrado != null)
            {
                DisplayAlert("¡Bienvenido!", $"Hola {usuarioEncontrado}!", "OK");
            }
            else
            {
                 DisplayAlert("Error de autenticación", "Nombre de usuario o contraseña incorrectos.", "OK");
            }
        }
        catch (Exception ex)
        {
            // Maneja errores de manera adecuada.
            DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
        }
    }

}

