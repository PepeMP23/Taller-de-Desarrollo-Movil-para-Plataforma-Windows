namespace TDMPW_1P_PR01;

public partial class Impuestos : ContentPage
{

    double monto = 0;
    double resultado = 0;

    public Impuestos()
	{
		InitializeComponent();
	}

    void ConIVA_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.cantidad.Text);
        resultado = monto * 1.16;

        this.txtResultado.Text = "La cantidad con IVA es de: " + resultado.ToString();
    }

    void SinIVA_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.cantidad.Text);
        resultado = monto / 1.16;

        this.txtResultado.Text = "La cantidad sin IVA es de: " + resultado.ToString();
    }
}
