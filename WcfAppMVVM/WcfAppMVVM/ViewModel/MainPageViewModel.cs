using ActiproSoftware.Windows.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WcfAppMVVM.ViewModel.Command;

namespace WcfAppMVVM.ViewModel
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            WelcomeText = "Witamy na pokladzie";
            HelloCommand = new DelegateCommand(HelloAction, HelloCanExecute);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public DelegateCommand HelloCommand { get; set; }

        public string WelcomeText { get; set; }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void HelloAction(object obj)
        {
            System.Diagnostics.Debug.WriteLine("HelloAction !");
        }

        private bool HelloCanExecute(object obj)
        {
            return true;
        }
    }
}
