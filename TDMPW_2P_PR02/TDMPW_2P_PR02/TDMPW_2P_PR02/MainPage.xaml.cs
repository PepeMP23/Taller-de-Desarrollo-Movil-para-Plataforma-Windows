namespace TDMPW_2P_PR02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void entryMonto_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
    }

    void btnCero_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 0;
        string montoInicial = entryMonto.Text;
        double cantidad = double.Parse(montoInicial);

        double costoEnvio = 0.00;
        double costoIVA = 0.00;
        double cantidadFinal;

        if(cantidad <= 100)
        {
            costoEnvio = 200;
        }
        if (cantidad > 100 && cantidad <= 200){
            costoEnvio = 100;
        }

        cantidadFinal = cantidad + costoEnvio + costoIVA;

        lblIVA.Text = costoIVA.ToString();
        lblEnvio.Text = costoEnvio.ToString();
        lblCantidadFinal.Text = cantidadFinal.ToString();
    }

    void btnOnce_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 11;
        string montoInicial = entryMonto.Text;
        double cantidad = double.Parse(montoInicial);

        double costoEnvio = 0.00;
        double costoIVA = Math.Round((cantidad * 0.11), 2);
        double cantidadFinal;

        if (cantidad <= 100)
        {
            costoEnvio = 200;
        }
        if (cantidad > 100 && cantidad <= 200)
        {
            costoEnvio = 100;
        }

        cantidadFinal = cantidad + costoEnvio + costoIVA;

        lblIVA.Text = costoIVA.ToString();
        lblEnvio.Text = costoEnvio.ToString();
        lblCantidadFinal.Text = cantidadFinal.ToString();
    }

    void btnDieciseis_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 16;
        string montoInicial = entryMonto.Text;
        double cantidad = double.Parse(montoInicial);

        double costoEnvio = 0.00;
        double costoIVA = Math.Round((cantidad * 0.16), 2);
        double cantidadFinal;

        if (cantidad <= 100)
        {
            costoEnvio = 200;
        }
        if (cantidad > 100 && cantidad <= 200)
        {
            costoEnvio = 100;
        }

        cantidadFinal = cantidad + costoEnvio + costoIVA;

        lblIVA.Text = costoIVA.ToString();
        lblEnvio.Text = costoEnvio.ToString();
        lblCantidadFinal.Text = cantidadFinal.ToString();
    }
}


