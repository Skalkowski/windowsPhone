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
    public partial class CalculatePage : PhoneApplicationPage
    {
        public CalculatePage()
        {
            InitializeComponent();
        }

        private void clear_Button_Click(object sender, RoutedEventArgs e)
        {
            distance_TextBox.Text = "0";
            time_TextBox.Text = "0";
        }

        private void time_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            float score = 0;
            score = float.Parse(distance_TextBox.Text) / float.Parse(time_TextBox.Text);
            string wynik = licz().ToString();
            score_TextBlock.Text = licz().ToString();
        }

        private double licz()
        {
            double dystans = double.Parse(distance_TextBox.Text);
            if (sprawdzDystans() == "Meters")
            {
                dystans = dystans / 1000;
            }
            else if (sprawdzDystans() == "Miles")
            {
                dystans = dystans * 1.609344;
            }
            else if (sprawdzDystans() == "Centimeters")
            {
                dystans = dystans / 100000;
            }

            double czas = double.Parse(time_TextBox.Text);
            if (sprawdzDystans() == "Minutes")
            {
                czas = czas / 60;
            }
            else if (sprawdzDystans() == "Seconds")
            {
                czas = czas / 3600;
            }
            return dystans/czas;
        }



        private string sprawdzCzas()
        {
            ListBoxItem lbi = (ListBoxItem)time_ListBox.SelectedItem;
            return (string)lbi.Content;
        }
        private string sprawdzDystans()
        {
            ListBoxItem lbi = (ListBoxItem)distance_ListBox.SelectedItem;
           return (string)lbi.Content;
        }

        private void back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}