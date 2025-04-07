using Microsoft.Maui.Controls;

namespace iainjobseeker.Views.JobSeeker;

public partial class AiInterviewPrepPage : ContentPage
{
	public AiInterviewPrepPage()
	{
		InitializeComponent();

    }

    //header navigations
    private async void OnMinimizeClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    //sidebar navigations
    private async void OnDashboardTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbDashboardPage());
    }

    private async void OnAiInterviewPrepTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AiInterviewPrepPage());
    }

    private async void OnSavedJobsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SavedJobPage());
    }

    private async void OnMessagesTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbMessagesPages());
    }

    private async void OnSettingsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbSettingsPage());
    }

    private async void OnAccountsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbAccountPage());
    }

    private async void OnHelpsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbHelpPage());
    }

    private void OffCamClicked(object sender, EventArgs e)
    {
        OffCamera.IsVisible = false;
        OnCamera.IsVisible = true;
    }

    private void OnCamClicked(object sender, EventArgs e)
    {
        OffCamera.IsVisible = true;
        OnCamera.IsVisible = false;
    }

    private void EndCallPrep(object sender, EventArgs e)
    {
        DisplayAlert("End Call Clicked", "You End the AI Interview Preparation!", "OK");
    }

}