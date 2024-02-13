namespace TDMPW_1P_PR06;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void btnDislikePrimerPersonaje_Clicked(System.Object sender, System.EventArgs e)
    {
        this.lblGustoPrimerPersonaje.Text = "No te gusto este personaje";
    }

    void btnLikePrimerPersonaje_Clicked(System.Object sender, System.EventArgs e)
    {
        this.lblGustoPrimerPersonaje.Text = "Te gusto este personaje";
    }

    void btnDislikeSegundoPersonaje_Clicked(System.Object sender, System.EventArgs e)
    {
        this.lblGustoSegundoPersonaje.Text = "No te gusto este personaje";
    }

    void btnLikeSegundoPersonaje_Clicked(System.Object sender, System.EventArgs e)
    {
        this.lblGustoSegundoPersonaje.Text = "Te gusto este personaje";
    }
}

