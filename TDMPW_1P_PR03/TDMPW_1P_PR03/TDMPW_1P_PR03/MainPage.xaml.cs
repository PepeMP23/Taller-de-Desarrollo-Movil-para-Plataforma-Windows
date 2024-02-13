namespace TDMPW_1P_PR03;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void btnMxn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MXN());
    }

    void btnUsd_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new USD());
    }

    void btnEur_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new EUR());
    }
}


