using iainjobseeker.Views.JobSeeker;

namespace iainjobseeker.Views.Authentication;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JbDashboardPage());
    }



    private async void OnSignUpTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignupPage());
    }

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChangePassPage());
    }

    private async void OnSkipTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnGoogleLoginTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Google Login", "Google login process here.", "OK");
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

    public interface IWindowService
    {
        void MinimizeWindow();
        void CloseWindow();
    }
}