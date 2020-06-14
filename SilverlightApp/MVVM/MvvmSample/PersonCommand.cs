using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MvvmSample
{
    public class PersonCommand : ICommand
    {
        PersonViewModel _PersonVM;
        public PersonCommand(PersonViewModel Pcame)
        {
            _PersonVM = Pcame;
        }

        public bool CanExecute(object parameter)
        {
            if (_PersonVM.p.Age > 25)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _PersonVM.Increaseage(_PersonVM.p);
        }
    }
}
