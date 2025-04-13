using System.Collections.ObjectModel;

namespace iainadmin.ViewModels
{
    public class ApplicantInfoRepo
    {
        private ObservableCollection<ApplicantInfo> _applicantInfos;

        // Public property to expose the collection
        public ObservableCollection<ApplicantInfo> ApplicantsInfos
        {
            get { return _applicantInfos; }
            set { _applicantInfos = value; }
        }

        public ApplicantInfoRepo()
        {
            _applicantInfos = new ObservableCollection<ApplicantInfo>();
            GenerateApplicants();
        }

        // Method to populate some sample data
        public void GenerateApplicants()
        {
            _applicantInfos.Add(new ApplicantInfo("Jacob", "jacob@email.com", "0999999999", "Malabon City", "January 9, 2024", "Pending Review"));
            _applicantInfos.Add(new ApplicantInfo("Alice", "alice@email.com", "0999888777", "Quezon City", "February 10, 2024", "Pending Review"));
            // Add more applicants as needed
        }
    }

    // Sample ApplicantInfo class with properties
    public class ApplicantInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ApplicationDate { get; set; }
        public string Status { get; set; }

        public ApplicantInfo(string name, string email, string phone, string address, string applicationDate, string status)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            ApplicationDate = applicationDate;
            Status = status;
        }
    }
}
