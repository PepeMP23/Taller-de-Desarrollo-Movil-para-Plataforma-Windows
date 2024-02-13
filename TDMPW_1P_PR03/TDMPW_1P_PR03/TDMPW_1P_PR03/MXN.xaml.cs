namespace TDMPW_1P_PR03;

public partial class MXN : ContentPage
{

    double cantidad = 0;
    double resultadoMxn = 0;

	public MXN()
	{
		InitializeComponent();
	}

    void btn_mxn_usd_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entMxn.Text);
        resultadoMxn = Math.Round((cantidad / 17.03), 2);

        this.txt_resultado_mxn.Text = resultadoMxn.ToString() + " USD";
    }

    void btn_mxn_eur_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entMxn.Text);
        resultadoMxn = Math.Round((cantidad / 18.56), 2);

        this.txt_resultado_mxn.Text = resultadoMxn.ToString() + " EUR";
    }
}
