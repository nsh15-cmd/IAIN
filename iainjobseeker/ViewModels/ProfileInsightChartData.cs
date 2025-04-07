using System.Collections.ObjectModel;
using System.ComponentModel;

namespace iainjobseeker.ViewModels;

public class ChartData
{
    public string XValue { get; set; } 
    public double YValue { get; set; }
    public Color SegmentColor { get; set; }
    public string FontFamily { get; set; } 
    public float FontSize { get; set; }
}

public class ProfileInsightPieChartViewModel : INotifyPropertyChanged
{
    public ObservableCollection<ChartData> Data { get; set; }

    public ProfileInsightPieChartViewModel()
    {
        // data for the pie chart
        Data = new ObservableCollection<ChartData>
            {
            new ChartData { XValue = "Afternoon", YValue = 32, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#8593ED") },

            new ChartData { XValue = "Evening", YValue = 28, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#5C6BC0") },

            new ChartData { XValue = "Night", YValue = 40, FontFamily = "PoppinsRegular", SegmentColor = Color.FromArgb("#5C7BC9") }
            };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
