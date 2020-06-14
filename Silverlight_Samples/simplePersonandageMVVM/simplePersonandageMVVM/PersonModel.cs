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
using System.ComponentModel;

namespace simplePersonandageMVVM
{
   
    public class PersonModel : INotifyPropertyChanged
    {
        string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                fire("Name");

            }
        }
        int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                fire("Age");
            }
        }
        public PersonModel() { }
        public PersonModel(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void fire(string x)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(x));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }


}
