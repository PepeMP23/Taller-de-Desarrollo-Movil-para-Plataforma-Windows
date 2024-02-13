namespace TDMPW_1P_PR04;

public partial class MainPage : FlyoutPage
{
    double monto = 0;
    double resultado = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void btnCalcularISR_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtCantidad.Text);
        resultado = monto - monto * 0.25;

        this.txtResultado.Text = resultado.ToString();
    }

    void btnCalcularIVA_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtCantidad.Text);
        resultado = monto + monto * 0.16;

        this.txtResultado.Text = resultado.ToString();
    }
}
