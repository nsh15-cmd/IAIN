using System.Collections.ObjectModel;

namespace iainadmin.ViewModels;

public class TeamManagementViewModel : ContentPage
{
    public ObservableCollection<Team> Teams { get; set; }

    public TeamManagementViewModel()
	{
        Teams = new ObservableCollection<Team>
        {
            new Team { Name = "John Doe", Position = "Manager", Status = "Offline" },
            new Team { Name = "Jane Smith", Position = "Developer", Status = "Online" },
            new Team { Name = "Michael Brown", Position = "Hr", Status = "Away" }
        };

    }

    public class Team
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
    }
}