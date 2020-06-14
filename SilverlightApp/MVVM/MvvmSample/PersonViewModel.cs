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
    public class PersonViewModel
    {
        public PersonModel p { get; set; }
        public PersonViewModel()
        {
            p = new PersonModel("prabjot", 20);
        }

        public ICommand PersonCommander
        {
            get { return new PersonCommand(this); }
        }

        public void Increaseage(PersonModel d)
        {
            d.Age++;
            string x = d.Age.ToString();
            MessageBox.Show(x);

        }
    }
}
