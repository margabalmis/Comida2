using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida2
{
    class MainWindowVM : INotifyPropertyChanged
    {
     
        private ObservableCollection<Plato> platoLista;

        public ObservableCollection<Plato> PlatoLista
        {
            get { return platoLista; }
            set {
                platoLista = value;
                NotifyPropertyChanged("PlatoLista");
            }
        }
        private string platoSeleccionados;

        public string PlatoSeleccionados
        {
            get { return platoSeleccionados; }
            set
            {
                platoSeleccionados = value;
                NotifyPropertyChanged("PlatoSeleccionados");
            }
        }

        public MainWindowVM()
        {

            platoLista = Plato.GetSamples(@"C:\FotosPlatos");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
