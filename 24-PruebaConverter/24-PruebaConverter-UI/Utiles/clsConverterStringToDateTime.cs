using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace _24_PruebaConverter_UI.Utiles
{
    public class clsConverterStringToDateTime : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
                DateTime date = (DateTime)value;
                return date.ToString("dd/MM/yyyy");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
                string dto = (string)value;
                return DateTime.Parse(dto);
        }
    }
}
