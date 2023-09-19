namespace ClinicApp.Pages;

public partial class MainPage : ContentPage
{

    private readonly httpServices _httpServices;

	public MainPage(httpServices httpServices)
	{
		InitializeComponent();
        _httpServices = httpServices;
	}

    public async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new HomePage());
	}
}

