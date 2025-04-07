namespace iainjobseeker.Views.Authentication;

public partial class ChangePassPage : ContentPage
{
	public ChangePassPage()
	{
		InitializeComponent();
	}

    private async void OnBackTapped(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnSubmitTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Change Password", "Change password process here.", "OK");
    }
    private void MinimizeWindow(object sender, EventArgs e)
    {
        var windowService = DependencyService.Get<IWindowService>();
        windowService?.MinimizeWindow();
    }
    private void CloseWindow(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    private async void CancelPasswordChangesClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void SavePasswordChangesClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


    public interface IWindowService
    {
        void MinimizeWindow();
        void CloseWindow();
    }

}