using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileAppProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            myFrame.Navigate(typeof(Home));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Home));
        }

        private void Story_Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Story));
        }
        private void Characters_Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Characters));
        }
        private void Weapons_Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Weapons));
        }
        private void Armor_Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Armor));
        }


        private void FLILOGO_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Credits));
        }

        private void AR_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(AR));
        }
    }
}
