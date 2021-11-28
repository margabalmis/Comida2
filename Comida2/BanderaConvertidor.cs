using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida2
{
    class BanderaConvertidor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String tipo = (string)value;
            String imagen ="";


            switch (tipo)
            {
                case "Americana":
                    imagen = "assets/united_states.png";
                    break;
                case "China":
                    imagen = "assets/china.png";
                    break;
                case "Mexicana":
                    imagen = "assets/mexico.png";
                    break;
            }
            return imagen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String imagen = (string)value;
            String tipo = "";


            switch (imagen)
            {
                case "assets/united_states.png":
                    tipo = "Americana";
                    break;
                case "assets/china.png":
                    tipo = "China";
                    break;
                case "assets/mexico.png":
                    tipo = "Mexicana";
                    break;
            }
            return tipo;
        }

    }
    
}
