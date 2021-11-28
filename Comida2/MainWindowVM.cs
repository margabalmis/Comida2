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
        private ObservableCollection<string> tiposComida;

        public ObservableCollection<string> TiposComida
        {
            get { return tiposComida; }
            set
            {
                tiposComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }


        private ObservableCollection<Plato> platoLista;

        public ObservableCollection<Plato> PlatoLista
        {
            get { return platoLista; }
            set {
                platoLista = value;
                NotifyPropertyChanged("PlatoLista");
            }
        }
        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("platoSeleccionado");
            }
        }

        public void QuitarSeleccionado()
        {
            PlatoSeleccionado = null;
        }


        public MainWindowVM()
        {

            PlatoLista = Plato.GetSamples(@"C:\FotosPlatos");
            TiposComida = new ObservableCollection<string> { "China", "Americana", "Mexicana" };

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
