using System.ComponentModel;

namespace TDMPW_3P_EJ01;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	int count = 0;
	string mensaje = "Hola te damos la bienvenida";
	string nombreImagen = "dotnet_bot.png";

	public string Mensaje {
		get  => mensaje;
		set
		{
			mensaje = value;
			OnPropertyChanged();
		}
	}

	public string NombreImagen
	{
		get => nombreImagen;
		set
		{
			nombreImagen = value;
			OnPropertyChanged();
		}
	}

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		if (count == 0)
		{
			NombreImagen = "logo_nutret.png";
			count++;
		}
		else
		{
			NombreImagen = "dotnet_bot.png";
			count = 0;
		}
    }
}


