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
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Calculate_Speed
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CalculatePage.xaml", UriKind.Relative));
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ConvertPage.xaml", UriKind.Relative));
        }

        
    }
}