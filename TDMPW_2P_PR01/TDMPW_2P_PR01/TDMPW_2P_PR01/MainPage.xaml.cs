namespace TDMPW_2P_PR01;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void entryNombre_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        string nombre = e.NewTextValue;
        labelNombre.Text = $"{nombre}";
    }

    void sliderControl_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        double sliderValue = Math.Round(e.NewValue);
        labelValue.Text = sliderValue.ToString("0.0");
    }

    void entryHobbie2_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        string nombre = e.NewTextValue;
        lblHobbie1.Text = $"{nombre}";
    }

    void stepperControl_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        sliderControl.Value = e.NewValue;
    }

    void switchControl_Toggled_1(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        bool isSwitchOn = e.Value;
        sliderControl.IsEnabled = !isSwitchOn;
        stepperControl.IsEnabled = isSwitchOn;
    }
}


