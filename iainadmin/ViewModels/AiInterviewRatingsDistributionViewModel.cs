using System.Collections.ObjectModel;
using System.ComponentModel;

namespace iainadmin.ViewModels;

public class AiInterviewRatingsDistributionViewModel
{
    public ObservableCollection<DataPoint> RatingsData { get; set; }

    public AiInterviewRatingsDistributionViewModel()
	{
        RatingsData = new ObservableCollection<DataPoint>
        {
            new DataPoint { Name = "Jan", Values = 10 },
            new DataPoint { Name = "Feb", Values = 15 },
            new DataPoint { Name = "Mar", Values = 12 },
            new DataPoint { Name = "Apr", Values = 20 }
        };
    }

    public class DataPoint
    {
        public string Name { get; set; }
        public double Values { get; set; }
    }
}