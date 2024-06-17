using Microsoft.Maui.Controls;
using System.Data;

namespace WetterMap;

public partial class SeiteDüsseldorf : ContentPage
{
    Wetter _wetter;
    public DateTime EventDate { get; }
    public DateTime EventTime { get; }
    public SeiteDüsseldorf()
    {
		InitializeComponent();
        _wetter = new Wetter();

        EventDate = DateTime.Now;
        BindingContext = this;

        //DateTime meinWert = DateTime.Now;
        //string EventTime = meinWert.ToShortTimeString();
        
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