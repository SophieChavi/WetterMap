namespace WetterMap;

public partial class SeiteStuttgart : ContentPage
{
    Wetter _wetter;
    public DateTime EventDate { get; }
    public SeiteStuttgart()
    {
        InitializeComponent();
        _wetter = new Wetter();

        EventDate = DateTime.Now;
        BindingContext = this;
    }


    async void GoAk(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(_cityEntry.Text))
        {
            WerteWetter werteWetter = await
                _wetter.
                GetWerteWetter(GenerateRequestURL(OpenWheater.OWWeb));

            BindingContext = werteWetter;
        }
    }

    string GenerateRequestURL(string endPoint)
    {
        string requestUri = endPoint;
        requestUri += $"?q={_cityEntry.Text}";
        requestUri += "&units=imperial";
        requestUri += $"&APPID={OpenWheater.OWApi}";
        return requestUri;
    }
}