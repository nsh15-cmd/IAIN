namespace iainadmin.ViewModels;

public class CandidateDropoffRateViewModel : ContentPage
{
	public CandidateDropoffRateViewModel()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}