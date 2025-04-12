using Syncfusion.Licensing;

namespace iainadmin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            MainPage = new NavigationPage(new iainadmin.Views.Autentication.LoginPage());

            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NNaF5cXmBCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWXxcd3VRQmNfVEd0V0FWYUA=");


        }
    }
}
