using iainjobseeker.ViewModels;
using System;

namespace iainjobseeker.Views.JobSeeker;

public partial class JbResumePage : ContentPage
{
	public JbResumePage()
	{
		InitializeComponent();
        BindingContext = new PdfViewerModel();
    }

	private void OnMinimizeClicked(object sender, EventArgs e)
	{
	}

    private void OnCloseClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

	private void BackButton_Tapped(object sender, EventArgs e)
    {
        Navigation.PopAsync();
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