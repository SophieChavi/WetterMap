namespace mappp
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("362f54d05dab982461792c629496ce5e");

            InitializeComponent();
            MainPage = new AppShell();
        }
    }
        //    <!--<Button x:Name="Cottbus" BackgroundColor="Blue" Text="Cottbus" SemanticProperties.Hint="Wetter in Cottbus" Clicked="zuCo"/>-->
        //<!--<Button x:Name="Düsseldorf" BackgroundColor="Green" Text="Düsseldorf" SemanticProperties.Hint="Wetter in Düsseldorf" Clicked="zuDü"/>
        //<Button x:Name="Stuttgard" BackgroundColor="Brown" Text="Stuttgard" SemanticProperties.Hint="Wetter in Stuttgard" Clicked="zuSt"/>-->
}
