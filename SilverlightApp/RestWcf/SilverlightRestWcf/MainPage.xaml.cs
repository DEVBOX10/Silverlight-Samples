using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SilverlightRestWcf
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 샘플1.
            //System.Windows.Browser.HtmlPage.Window.Navigate(navigateToUri, "_blank");
            //NavigateToURLInNewWindow(new Uri("/sr/Volunteer", UriKind.Relative));

            // 샘플2.
            //HyperlinkButton hb = new HyperlinkButton()
            //{
            //    NavigateUri = new Uri(url),
            //    TargetName = "_blank"
            //};
            //(new HyperlinkButtonAutomationPeer(hb) as IInvokeProvider).Invoke();


            //SilverlightRestWcfTestPage.aspx

            //RestWcfPage page = new RestWcfPage();
            //Application.Current.RootVisual = page; // 의미없음, 변경안됨.
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            //string url = "RestWcfPage.xaml";
            //System.Windows.Browser.HtmlPage.Window.Navigate(new Uri(url, UriKind.Relative));
        }

        private void btnGoRestWcf_Click(object sender, RoutedEventArgs e)
        {
            string url = "/SilverlightRestWcfTestPage.aspx#/RestWcfPage.xaml";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri(url, UriKind.Relative));
        }

        private void btnGoPage_Click(object sender, RoutedEventArgs e)
        {
            string url = "/SilverlightRestWcfTestPage.aspx#/Page1.xaml";
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
