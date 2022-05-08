namespace Maui_InsertPageBeforeForcesNavigationBar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}
