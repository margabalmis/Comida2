﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;

class Plato : INotifyPropertyChanged
{
    private string nombre;
    public string Nombre
    {
        get { return nombre; }
        set {
            if (this.nombre != value)
            {
                this.nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }

        }
    }
    private string imagen;
    public string Imagen
    {
        get { return imagen; }
        set
        {
            if (this.imagen != value)
            {
                this.imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }

        }
    }

    private string tipo;
    public string Tipo
    {
        get { return tipo; }
        set
        {
            if (this.tipo != value)
            {
                this.tipo = value;
                this.NotifyPropertyChanged("Tipo");
            }

        }
    }
    private bool gluten;
    public bool Gluten
    {
        get { return gluten; }
        set
        {
            if (this.gluten != value)
            {
                this.gluten = value;
                this.NotifyPropertyChanged("Gluten");
            }

        }
    }

    private bool soja;
    public bool Soja
    {
        get { return soja; }
        set
        {
            if (this.soja != value)
            {
                this.soja = value;
                this.NotifyPropertyChanged("Soja");
            }

        }
    }
    private bool leche;
    public bool Leche
    {
        get { return leche; }
        set
        {
            if (this.leche != value)
            {
                this.leche = value;
                this.NotifyPropertyChanged("Leche");
            }

        }
    }
    private bool sulfitos;
    public bool Sulfitos
    {
        get { return sulfitos; }
        set
        {
            if (this.sulfitos != value)
            {
                this.sulfitos = value;
                this.NotifyPropertyChanged("Sulfitos");
            }

        }
    }
 

    public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
    {
        Nombre = nombre;
        Imagen = imagen;
        Tipo = tipo;
        Gluten = gluten;
        Soja = soja;
        Leche = leche;
        Sulfitos = sulfitos;
    }

    public Plato()
    {
    }

    public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
    {
        ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

        lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
        lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
        lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
        lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
        lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
        lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

        return lista;
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public void NotifyPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

