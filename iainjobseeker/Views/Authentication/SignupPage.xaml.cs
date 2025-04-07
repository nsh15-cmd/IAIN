using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace iainjobseeker.Views.Authentication;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
	}

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        if (TermsCheckBox.IsChecked)
        {
            DisplayAlert("Sign-Up", "Proceeding with Sign-Up!", "OK");
        }
        else
        {
            DisplayAlert("Error", "You must agree to the terms and conditions.", "OK");
        }

        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }

    private async void OnLoginTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

    private async void OnGoogleLoginTapped(object sender, EventArgs e)
    {
        await DisplayAlert("Google Login", "Google login process here.", "OK");
    }

    public async void OnTermsTapped(object sender, EventArgs e)
    {

        var tcs = new TaskCompletionSource<bool>();

        var termsPage = new TermsPage(tcs);
        await Navigation.PushAsync(termsPage);

        bool acceptedTerms = await tcs.Task;

        if (acceptedTerms)
        {
            TermsCheckBox.IsChecked = true;
        }
    }
}