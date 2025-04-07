using System.ComponentModel;
using System.IO;

namespace iainjobseeker.ViewModels
{
    public class PdfViewerModel : INotifyPropertyChanged
    {
        private string _pdfPath;
        public string PdfPath
        {
            get => _pdfPath;
            set
            {
                if (_pdfPath != value)
                {
                    _pdfPath = value;
                    OnPropertyChanged(nameof(PdfPath));
                }
            }
        }
        public PdfViewerModel()
        {
            // Set the path to the PDF file
            PdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "sample.pdf");
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
