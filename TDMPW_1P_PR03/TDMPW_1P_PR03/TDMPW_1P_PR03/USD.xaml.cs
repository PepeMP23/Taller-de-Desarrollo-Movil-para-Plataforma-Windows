namespace TDMPW_1P_PR03;

public partial class USD : ContentPage
{

    double cantidad = 0;
    double resultadoEur = 0;

	public USD()
	{
		InitializeComponent();
	}

    void btn_usd_mxn_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entUsd.Text);
        resultadoEur = Math.Round((cantidad * 17.03), 2);

        this.txt_resultado_usd.Text = resultadoEur.ToString() + " MXN";
    }

    void btn_usd_eur_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.entUsd.Text);
        resultadoEur = Math.Round((cantidad / 1.09), 2);

        this.txt_resultado_usd.Text = resultadoEur.ToString() + " EUR";
    }
}
