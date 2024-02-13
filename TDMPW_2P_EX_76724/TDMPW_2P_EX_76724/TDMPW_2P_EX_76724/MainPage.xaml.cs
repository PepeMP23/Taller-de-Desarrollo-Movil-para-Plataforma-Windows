using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace TDMPW_2P_EX_76724;

public partial class MainPage : TabbedPage
{
    double precio = 0.0;

    public MainPage()
	{
		InitializeComponent();
	}

    void producto_uno_Clicked(System.Object sender, System.EventArgs e)
    {
        imagenProducto.Source = "cheesecake.png";
        this.lblNombre.Text = "Cheesecake Roulet";
        this.lblDescripcion.Text = "Contiene glúten, huevo, leche y derivados. Puede contener trazas de frutos de cáscara, soja, pescado, sésamo.";
        this.lblPrecio.Text = "$ 55.00";
        this.lblTotal.Text = "55.00";
        lblCantidad.Text = "1";
        stepper.Value = 1;
        precio = 55.0;
    }

    void producto_dos_Clicked(System.Object sender, System.EventArgs e)
    {
        imagenProducto.Source = "caramel.png";
        this.lblNombre.Text = "Caramel Macchiato";
        this.lblDescripcion.Text = "Leche al vapor manchada con espresso y un toque de vainilla, cubierta con un característico dibujo de caramelo. Dulce, intenso y único.";
        this.lblPrecio.Text = "$ 82.00";
        this.lblTotal.Text = "82.00";
        lblCantidad.Text = "1";
        stepper.Value = 1;
        precio = 82.0;
    }

    void producto_tres_Clicked(System.Object sender, System.EventArgs e)
    {
        imagenProducto.Source = "croissant.png";
        this.lblNombre.Text = "Croissant";
        this.lblDescripcion.Text = "Contiene: gluten, huevos y leche. Puede contener frutos de cáscara, soja y sésamo";
        this.lblPrecio.Text = "$ 64.00";
        this.lblTotal.Text = "64.00";
        lblCantidad.Text = "1";
        stepper.Value = 1;
        precio = 64.00;
    }

    void Stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e) {
        double valorStepper = e.NewValue;
        lblCantidad.Text = valorStepper.ToString();

        double resultado = valorStepper * precio;
        lblTotal.Text = resultado.ToString();
    }
}


