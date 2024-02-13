namespace TDMPW_1P_PR03;

public partial class EUR : ContentPage
{

    double cantidad = 0;
    double resultadoEur = 0;

	public EUR()
	{
		InitializeComponent();
	}

    void btn_eur_mxn_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entEur.Text);
        resultadoEur = Math.Round((cantidad * 18.56), 2);

        this.txt_resultado_eur.Text = resultadoEur.ToString() + " MXN";
    }

    void btn_eur_usd_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entEur.Text);
        resultadoEur = Math.Round((cantidad * 1.09), 2);

        this.txt_resultado_eur.Text = resultadoEur.ToString() + " USD";
    }
}
