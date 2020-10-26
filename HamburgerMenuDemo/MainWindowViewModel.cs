using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HamburgerMenuDemo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private bool isSearchedChecked;
        private bool isHomeChecked;

        public ICommand ClickCommand { get; private set; } = new DelegateCommand<object>(OnClick, CanExecute);

        public event PropertyChangedEventHandler PropertyChanged;

        private static bool CanExecute(object arg)
        {
            return true;
        }

        private static void OnClick(object obj)
        {
            Console.WriteLine(obj);
            //  MessageBox.Show("Clicked!");
        }

        public bool IsSearchChecked
        {
            get => isSearchedChecked;
            set
            {
                isSearchedChecked = value;
                NotifyPropertyChanged();
            }
        }

        public bool IsHomeChecked
        {
            get => isHomeChecked;
            set
            {
                isHomeChecked = value;
                NotifyPropertyChanged();
            }
        }

     

        public void NotifyPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public MainWindowViewModel()
        {

        }
    }
}
