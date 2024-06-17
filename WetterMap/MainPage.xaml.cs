namespace WetterMap
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }
        // Für meine Wetter Seiten, zum navigieren mit Buttons:
        public async void GoBack(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); //meine Seite verwerfen
        }
        private async void GoCo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeiteCottbus());
        }

        private async void GoDü(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeiteDüsseldorf());
        }

        private async void GoSt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeiteStuttgart());
        }
        // l


    }

}
