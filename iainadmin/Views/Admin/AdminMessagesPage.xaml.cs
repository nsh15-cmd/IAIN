namespace iainadmin.Views.Admin;

public partial class AdminMessagesPage : ContentPage
{
	public AdminMessagesPage()
	{
		InitializeComponent();
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

    private async void SendMessage(object sender, EventArgs e)
    {
        // Your logic goes here, for now, we show a simple alert.
        await DisplayAlert("Sent Message", "...", "OK");
    }

}