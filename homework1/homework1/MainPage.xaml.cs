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

namespace homework1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void sprawdzenieButton_Click(object sender, RoutedEventArgs e)
        {
            odpowiedzBlock.Text = (numeryBox.Text == "4 8 15 16 23 42") ? "Recalibrating energy core.... Complete." : "FAILURE!";
            
            //if (numeryBox.Text == "4 8 15 16 23 42")
            //{
            //    odpowiedzBlock.Text = "Recalibrating energy core.... Complete.";
            //}
            //else
            //{
            //    odpowiedzBlock.Text = "FAILURE!";
            //}
        }

        private void sprawdzenieButton_Loaded(object sender, RoutedEventArgs e)
        {
            numeryBox.Focus();
        }
    }
}