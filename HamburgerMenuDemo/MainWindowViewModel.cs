using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HamburgerMenuDemo
{
    public class MainWindowViewModel
    {
        public ICommand ClickCommand { get; private set; } = new DelegateCommand<object>(OnClick, CanExecute);

        private static bool CanExecute(object arg)
        {
            return true;
        }

        private static void OnClick(object obj)
        {
            Console.WriteLine(obj);
          //  MessageBox.Show("Clicked!");
        }

        

        public MainWindowViewModel()
        {

        }
    }
}
