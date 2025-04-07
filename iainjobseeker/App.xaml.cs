using Syncfusion.Licensing;


namespace iainjobseeker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage = new NavigationPage(new iainjobseeker.Views.Authentication.LoginPage());

            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXxcd3VRQmNfVEd0V0FWYUA=");

        }
    }
}
