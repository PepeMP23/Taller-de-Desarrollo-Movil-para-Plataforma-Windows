namespace TDMPW_1P_PR02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void txt_celcius_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Celcius());
    }

    void txt_kelvin_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Kelvin());
    }

    void txt_fahrenheit_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Fahrenheit());
    }

    
}


