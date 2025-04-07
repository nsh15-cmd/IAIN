using Microsoft.Maui.Controls;

namespace iainjobseeker.Views.JobSeeker;

public partial class SavedJobPage : ContentPage
{
	public SavedJobPage()
	{
		InitializeComponent();
    }

    //header navigations
    private async void OnMinimizeClicked(object sender, EventArgs e)
    {
        //minimize logic i cant find haha sorry dami errors
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
}