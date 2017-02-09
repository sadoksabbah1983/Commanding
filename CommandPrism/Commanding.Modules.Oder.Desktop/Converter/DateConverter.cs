using System;
using System.Globalization;
using System.Windows.Data;

namespace Commanding.Modules.Oder.Desktop.Converter
{
    public class DateConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime date = (DateTime)value;
            return date.ToString("d", culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            DateTime resultatDateTime;
            if (DateTime.TryParse(strValue, culture, DateTimeStyles.None, out resultatDateTime))
            {
                return resultatDateTime;
            }
            return value;
        }
    }
}
