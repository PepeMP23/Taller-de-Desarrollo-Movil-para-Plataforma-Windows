namespace TDMPW_1P_EX_76724;

public partial class MainPage : TabbedPage
{
    double amperios = 0;
    double voltios = 0;
    double watts = 0;
    double joules = 0;
    double segundos = 0;
    double wattsSegundo = 0;

    public MainPage()
	{
		InitializeComponent();
	}

    void btncalcularWatts_Clicked(System.Object sender, System.EventArgs e)
    {
        amperios = double.Parse(this.entAmperios.Text);
        voltios = double.Parse(this.entVoltios.Text);

        watts = Math.Round((amperios * voltios), 2);

        this.lblResultadoWatts.Text = watts.ToString() + " Watts";
    }

    void btncalcularProceso_Clicked(System.Object sender, System.EventArgs e)
    {
        joules = double.Parse(this.entJoules.Text);
        segundos = double.Parse(this.entSegundos.Text);

        wattsSegundo = Math.Round((joules / segundos), 2);

        this.lblResultadoPotencia.Text = wattsSegundo.ToString() + " Watts";
    }

    
}


