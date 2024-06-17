using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterMap
{
    public class CelciusAngabe : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double fahren = (double)value;
            double celcius = 0.00;
            if (!ReferenceEquals(fahren, null))
            {
                celcius = (fahren - 32) * 5 / 9;
            }
            return Math.Round(celcius).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
