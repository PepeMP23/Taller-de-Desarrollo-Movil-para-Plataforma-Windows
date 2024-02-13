namespace TDMPW_1P_PR02;

public partial class Kelvin : ContentPage
{
    double kelvin = 0;
    double resultadoKelvin = 0;

    public Kelvin()
	{
		InitializeComponent();
	}

    void btnKelvinCelcius_Clicked(System.Object sender, System.EventArgs e)
    {
        kelvin = double.Parse(this.entryKelvin.Text);
        resultadoKelvin = Math.Round((kelvin - 273.15), 2);

        this.txtResultadoKelvin.Text = "La cantidad en Celcius es de: " + resultadoKelvin.ToString();
    }

    void btnKelvinFahrenheit_Clicked(System.Object sender, System.EventArgs e)
    {
        kelvin = double.Parse(this.entryKelvin.Text);
        resultadoKelvin = Math.Round((1.8 * (kelvin - 273.15) + 32), 2);

        this.txtResultadoKelvin.Text = "La cantidad en Fahrenheit es de: " + resultadoKelvin.ToString();
    }
}
