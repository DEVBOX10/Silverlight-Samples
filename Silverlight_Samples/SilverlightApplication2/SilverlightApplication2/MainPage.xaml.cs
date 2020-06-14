using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication2
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox txtBox = this.FindName("txtTest") as TextBox;
            Label lbl = this.FindName("lblTest") as Label;
            Image img = this.FindName("img1") as Image;

            if(txtBox!= null && lbl != null)
            {
                //txtBox.Text = "Hello World!";
                lbl.Content = "Hello World! " + txtBox.Text;
            }

            Uri uri = new Uri(App.Current.Host.Source, "../img/test.png"); //new Uri(@"D:\Dev\SilverlightApplication2\SilverlightApplication2\img\test.png");
            img1.Source = new System.Windows.Media.Imaging.BitmapImage(uri);
            img.Source = new System.Windows.Media.Imaging.BitmapImage(uri);
            
            //WebClient client = new WebClient();
            //client.OpenReadCompleted += new OpenReadCompletedEventHandler(client_OpenReadCompleted);
            //client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            //client.OpenReadAsync(new Uri(App.Current.Host.Source, "../img/test.png"));
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            TextBox txtBox = this.FindName("txtTest") as TextBox;
            txtBox.Text = "Loading ... " + string.Format("{0}", e.ProgressPercentage) + " %";
        }

        private void client_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            System.Windows.Resources.StreamResourceInfo sri = new System.Windows.Resources.StreamResourceInfo(e.Result as Stream, null);
            System.Windows.Media.Imaging.BitmapImage imgsrc = new System.Windows.Media.Imaging.BitmapImage();
            imgsrc.SetSource(sri.Stream);

            Image img = this.FindName("img1") as Image;
            img.Source = imgsrc;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var input = txtTest.Text.Trim();

        }
    }
}
