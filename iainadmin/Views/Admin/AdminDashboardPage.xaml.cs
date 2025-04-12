using iainadmin.ViewModels;
using Syncfusion.Maui.Charts;

namespace iainadmin.Views.Admin;

public partial class AdminDashboardPage : ContentPage
{
    public AdminDashboardPage()
	{
		InitializeComponent();
        BindingContext = new JobPostPerformanceViewModel();
        BindingContext = new AiInterviewSuccessTrendsViewModel();


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

    private async void OnDashboardTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminDashboardPage());
    }

    private async void OnJobPostingTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminJobPostingPage());
    }

    private async void OnApplicantsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminApplicantsPage());
    }

    private async void OnMessagesTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminMessagesPage());
    }

    private async void OnReportsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminReportsPage());
    }

    private async void OnManagementTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminManagementPage());
    }

    private async void OnAccountsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminAccountsPage());
    }

    private async void OnSettingsTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminSettingsPage());
    }

    private async void OnHelpTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new AdminHelpPage());
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
}