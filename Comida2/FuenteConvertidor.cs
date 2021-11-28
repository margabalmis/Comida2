using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida2
{
    class FuenteConvertidor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String tipo = (string)value;
            String fuente ="";


            switch (tipo)
            {
                case "Americana":
                    fuente = "Slim Summer";
                    break;
                case "China":
                    fuente = "Chinese Wok Food St";
                    break;
                case "Mexicana":
                    fuente = "Taco Salad";
                    break;
            }
            return fuente;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String fuente = (string)value;
            String tipo = "";


            switch (fuente)
            {
                case "Slim Summer":
                    tipo = "Americana";
                    break;
                case "Chinese Wok Food St":
                    tipo = "China";
                    break;
                case "Taco Salad":
                    tipo = "Mexicana";
                    break;
            }
            return tipo;
        }

    }
    
}
