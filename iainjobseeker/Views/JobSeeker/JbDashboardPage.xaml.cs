using Syncfusion.Maui.Core;
using System;
using Microsoft.Maui.Controls;
using iainjobseeker.ViewModels;

namespace iainjobseeker.Views.JobSeeker;


public partial class JbDashboardPage : ContentPage
{
	public JbDashboardPage()
	{
		InitializeComponent();
        BindingContext = new ProfileInsightPieChartViewModel();

    }

    private void OnMinimizeClicked(object sender, EventArgs e)
    {
#if WINDOWS
        var window = (Microsoft.UI.Xaml.Window)App.Current.Windows[0].Handler.PlatformView;
        var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
#endif
    }

    private void OnCloseClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    private void OnPickerDateSelect(object sender, EventArgs e)
    {
        var picker = (Picker)sender;

        // Ensure that we get a valid SelectedItem
        if (picker.SelectedItem != null)
        {
            var selectedOption = picker.SelectedItem.ToString();
            DisplayAlert("Selected Option", $"You selected: {selectedOption}", "OK");
        }
        else
        {
            // Handle case when nothing is selected
            DisplayAlert("Selection Error", "No option selected.", "OK");
        }
    }

    private async void OnInsertResumeTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new JbResumePage());
    }

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