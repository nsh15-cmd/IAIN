namespace iainjobseeker.Views.Authentication;

public partial class TermsPage : ContentPage
{
    private TaskCompletionSource<bool> _tcs;

    public TermsPage(TaskCompletionSource<bool> tcs)
    {
        InitializeComponent();
        _tcs = tcs;
    }

    private async void OnAcceptTapped(object sender, EventArgs e)
    {
        _tcs.SetResult(true);
        await Navigation.PopAsync();
    }

    private async void OnDeclineTapped(object sender, EventArgs e)
    {
        _tcs.SetResult(false);
        await Navigation.PopAsync();
    }

    private async void CloseWindow(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    // Minimize window function (optional)
    private async void MinimizeWindow(object sender, EventArgs e)
    {
    }
}
