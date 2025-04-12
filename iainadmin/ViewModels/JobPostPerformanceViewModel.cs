using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Maui.Graphics;

namespace iainadmin.ViewModels
{
    public class ChartData
    {
        public string XValue { get; set; }
        public double YValue { get; set; }
        public Color SegmentColor { get; set; }
        public string FontFamily { get; set; }
        public float FontSize { get; set; }
    }

    public class JobPostPerformanceViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ChartData> PerformanceData { get; set; }

        public JobPostPerformanceViewModel()
        {
            // Dummy data just to make sure it shows something
            PerformanceData = new ObservableCollection<ChartData>
            {
                new ChartData { XValue = "Passed", YValue = 32, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#8593ED"), FontSize = 12 },
                new ChartData { XValue = "Failed", YValue = 28, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#5C6BC0"), FontSize = 12 },
                new ChartData { XValue = "Rejected", YValue = 40, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#5C7BC9"), FontSize = 12 }
            };
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
