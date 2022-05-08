namespace Maui_InsertPageBeforeForcesNavigationBar;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

  private async void Back_Clicked(object sender, EventArgs e)
  {
		await Navigation.PopAsync();
	}
}