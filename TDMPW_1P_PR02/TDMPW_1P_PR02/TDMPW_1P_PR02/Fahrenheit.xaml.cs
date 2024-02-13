namespace TDMPW_1P_PR02;

public partial class Fahrenheit : ContentPage
{

    double fahrenheit = 0;
    double resultadoFahrenheit = 0;

	public Fahrenheit()
	{
		InitializeComponent();
	}

    void btnFahrenheitCelcius_Clicked(System.Object sender, System.EventArgs e)
    {
        fahrenheit = double.Parse(this.entFahrenheit.Text);
        resultadoFahrenheit = Math.Round(((fahrenheit -32) / 1.8), 2);

        this.txtResultadoFahrenheit.Text = "La cantidad en Celcius es de: " + resultadoFahrenheit.ToString();
    }

    void btnFahrenheitKelvin_Clicked(System.Object sender, System.EventArgs e)
    {
        fahrenheit = double.Parse(this.entFahrenheit.Text);
        resultadoFahrenheit = Math.Round((((fahrenheit - 32) / 1.8) + 273.15), 2);

        this.txtResultadoFahrenheit.Text = "La cantidad en Kelvin es de: " + resultadoFahrenheit.ToString();
    }
}
