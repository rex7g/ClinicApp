using ClinicApp.Models;
using ClinicApp.Pages;
using ClinicApp.Services;
using System.ComponentModel.DataAnnotations;

namespace ClinicApp;

public partial class MainPage : ContentPage
{

    private readonly IHttpService _httpServices;

	public MainPage(IHttpService service)
	{
		InitializeComponent();
		_httpServices = service;
	}

    public async void Button_Clicked(object sender, EventArgs e)
	{
		var usuario=user.Text.Trim();
		var Password=password.Text.Trim();
		var ValidaUsuario = await _httpServices.GetUsuario(usuario);


        if (ValidaUsuario != null && ValidaUsuario.Nombre == usuario )
        {
            await Navigation.PushModalAsync(new HomePage());
        }
       
	}
}

