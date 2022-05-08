namespace Maui_InsertPageBeforeForcesNavigationBar;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnGoToPage3(object sender, EventArgs e)
	{
		var page3 = new Page3();
		await Navigation.PushAsync(page3);
		Navigation.InsertPageBefore(new Page2(), page3);
	}
}

