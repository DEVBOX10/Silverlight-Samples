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

namespace simplePersonandageMVVM
{
    public class GetPersonCommand : ICommand
    {
        PersonViewModel pincommand;
        public GetPersonCommand( PersonViewModel Pcame)
        { 
          pincommand= Pcame;
           
           
        }

        public bool CanExecute(object parameter)
        {
           if(pincommand.p.Age > 25)
           {
               return false ;
           }
        else
           {
               return true;
           }
            
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
           pincommand.Increaseage(pincommand.p);
        }
    }
}
