namespace TDMPW_P1_PR05;

public partial class MainPage : ContentPage
{
    int contador = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void sld1_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        this.sld1.Value = Math.Round(this.sld1.Value, 0);
        this.lblSlider1.Text = this.sld1.Value.ToString();
    }

    void sld2_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        this.sld2.Value = Math.Round(this.sld2.Value, 0);
        this.lblSlider2.Text = this.sld2.Value.ToString();
    }

    void sld3_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        this.sld3.Value = Math.Round(this.sld3.Value, 0);
        this.lblSlider3.Text = this.sld3.Value.ToString();
    }

    void stp1_Clicked(System.Object sender, System.EventArgs e)
    {
        contador++;

        sld1.Value = sld1.Value + 1;
        if (sld1.Value == 10)
        {
            sld2.Value = sld2.Value +1;
        }
        if (sld2.Value == 20)
        {
            sld3.Value = sld3.Value + 1;
        }
        if (sld3.Value == 30)
        {
            lblTitle.Text = "YA GANASTE!";
        }

        if (btn1.IsPressed)
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
            this.lblScore.Text = contador.ToString();

        }
        if (btn2.IsPressed)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
            this.lblScore.Text = contador.ToString();
        }

        this.lblScore.Text = contador.ToString();

        
        /*
        this.lblStp1.Text = this.stp1.ToString();
      
        this.sld1.Value = this.stp1.Value;

        if (this.sld1.Value == 10)
        {
            this.sld2.Value = this.stp1.Value;
        }
        if (this.sld2.Value == 20)
        {
            this.sld3.Value = this.stp1.Value;
        }
        

        if (stp1.IsPressed)
        {
            stp1.IsEnabled = false;
            stp2.IsEnabled = true;
        }
        if (stp2.IsPressed)
        {
            stp1.IsEnabled = true;
            stp2.IsEnabled = false;
        }
        */

    }

    
}


