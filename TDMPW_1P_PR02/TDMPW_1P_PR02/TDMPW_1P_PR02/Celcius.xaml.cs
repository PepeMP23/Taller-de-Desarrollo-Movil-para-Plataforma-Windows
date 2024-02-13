namespace TDMPW_1P_PR02;

public partial class Celcius : ContentPage
{
    double celcius = 0;
    double resultadoCelcius = 0;

    public Celcius()
	{
		InitializeComponent();
	}

    void btnCelciusKelvin_Clicked(System.Object sender, System.EventArgs e)
    {
        celcius = double.Parse(this.entCelcius.Text);
        resultadoCelcius = Math.Round((celcius + 273.15), 2);

        this.txtResultadoCelcius.Text = "La cantidad en Kelvin es de: " + resultadoCelcius.ToString();
    }

    void btnCelciusFahrenheit_Clicked(System.Object sender, System.EventArgs e)
    {
        celcius = double.Parse(this.entCelcius.Text);
        resultadoCelcius = Math.Round(((celcius * (1.8)) + 32), 2);

        this.txtResultadoCelcius.Text = "La cantidad en Fahrenheit es de: " + resultadoCelcius.ToString();
    }

}
