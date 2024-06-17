namespace WetterMap
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("362f54d05dab982461792c629496ce5e");
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
