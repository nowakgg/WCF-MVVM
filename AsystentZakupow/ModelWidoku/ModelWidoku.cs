using Polecenie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModelWidoku
{
    public class ModelWidoku : INotifyPropertyChanged
    {
        private ICommand dodajKwote;
        private Sumator.Sumator model = new Sumator.Sumator(1000, 0);

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand DodajKwote
        {
            get
            {
                if (dodajKwote == null)
                    dodajKwote = new RelayCommand(
                        (object argument) =>
                        {
                            decimal kwota = decimal.Parse((string)argument);
                            model.Dodaj(kwota);
                            OnPropertyChanged(nameof(Suma));
                        },
                        (object argumet) =>
                        {
                            return CzyLancuchKwotyJestPoprawny((string)argumet);
                        });
                return dodajKwote;
            }
        }

        public decimal Suma
        {
            get
            {
                return model.Suma;
            }
        }

        public bool CzyLancuchKwotyJestPoprawny(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return false;
            decimal kwota;
            if (!decimal.TryParse(s, out kwota)) return false;
            else return model.CzyKwotaJestPoprawna(kwota);
        }

        private void OnPropertyChanged(string nazwaWlasnosci)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(nazwaWlasnosci));
        }
    }
}
