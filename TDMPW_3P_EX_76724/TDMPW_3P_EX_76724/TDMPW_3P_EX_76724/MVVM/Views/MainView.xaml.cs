namespace TDMPW_3P_EX_76724.MVVM.Views;
using TDMPW_3P_EX_76724.MVVM.ViewModels;

public partial class MainView : TabbedPage
{
	public MainView()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}
