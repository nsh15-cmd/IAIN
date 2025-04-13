using System.Collections.ObjectModel;
using System.ComponentModel;

namespace iainadmin.ViewModels
{
    public class AiInterviewSuccessTrendsViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<InterviewTrendModel> Data { get; set; }

        public AiInterviewSuccessTrendsViewModel()
        {
            Data = new ObservableCollection<InterviewTrendModel>
            {
                new InterviewTrendModel { Month = "Jan", Percentage = 60 },
                new InterviewTrendModel { Month = "Feb", Percentage = 68 },
                new InterviewTrendModel { Month = "Mar", Percentage = 72 },
                new InterviewTrendModel { Month = "Apr", Percentage = 70 },
                new InterviewTrendModel { Month = "May", Percentage = 75 },
                new InterviewTrendModel { Month = "Jun", Percentage = 78 },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class InterviewTrendModel
    {
        public string Month { get; set; }
        public double Percentage { get; set; }
    }
}
