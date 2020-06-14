using SilverlightRestWcf.Model;
using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace SilverlightRestWcf
{
    /// <summary>
    /// http://www.nuget.org/packages/Microsoft.CompilerServices.AsyncTargetingPack
    /// PM> Install-Package Microsoft.CompilerServices.AsyncTargetingPack -Version 1.0.1
    /// </summary>
    public partial class RestWcfPage
    {
        public RestWcfPage()
        {
            InitializeComponent();
        }

        private async void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            var request = new WebClient();
            var uri = new Uri("http://localhost:62271/svc/cars");
            var jsonString = await request.DownloadStringTaskAsync(uri);

            using (var stream = new MemoryStream(Encoding.Unicode.GetBytes(jsonString.ToCharArray())))
            {
                var serializer = new DataContractJsonSerializer(typeof (Car[]));
                var cars = (Car[]) serializer.ReadObject(stream);
                CarsListBox.ItemsSource = cars;
            }
        }
    }
}