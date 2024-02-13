namespace TDMPW_1P_EJ01;

public partial class Pagina2 : ContentPage
{
	int n1 = 0;
	int n2 = 0;
	int resultado = 0;

	public Pagina2()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		// .Text de lado derecho es como un get Text
		n1 = int.Parse(this.txtN1.Text);
		n2 = int.Parse(this.txtN2.Text);

		resultado = n1 + n2;

		// .Text de lado ixquierdo es como un set Text
		this.txtResultado.Text = "Resultado: " + resultado.ToString();
    }
}
