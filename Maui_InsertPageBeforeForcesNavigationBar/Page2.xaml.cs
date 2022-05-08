namespace Maui_InsertPageBeforeForcesNavigationBar;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

  private async void Back_Clicked(object sender, EventArgs e)
  {
		await Navigation.PopAsync();
  }
}