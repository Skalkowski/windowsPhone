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

namespace BMI
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void licz_Click(object sender, RoutedEventArgs e)
        {
            wagaBox.Text = "";
            wzrostBox.Text = "";
        }

        private void wzrostBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            float wynik;
            if (wzrostBox.Text != null)
            {
                float wzrostF = float.Parse(wzrostBox.Text);
                if (wzrostF > 3)
                {
                    wzrostF = wzrostF / 100;
                }
                wynik = float.Parse(wagaBox.Text) / (wzrostF * wzrostF);
                wynikBlock.Text = wynik.ToString();
            }
            
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            wagaBox.Focus();
        }
    }
}