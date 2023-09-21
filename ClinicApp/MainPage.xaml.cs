using ClinicApp.Services;

namespace ClinicApp;

public partial class MainPage : ContentPage
{

    private readonly httpServices _httpServices;

	public MainPage()
	{
		InitializeComponent();
	}

    public async void Button_Clicked(object sender, EventArgs e)
	{
		//await Navigation.PushModalAsync(new HomePage());
	}
}

