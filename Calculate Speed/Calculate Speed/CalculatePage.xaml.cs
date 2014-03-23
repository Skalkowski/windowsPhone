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
        Boolean czyAkcja = false;
        public CalculatePage()
        {
            InitializeComponent();
        }

        private void clear_Button_Click(object sender, RoutedEventArgs e)
        {
            distance_TextBox.Text = "";
            time_TextBox.Text = "";
        }

        private void time_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            float score = 0;
            if (!distance_TextBox.Text.Equals("") && !time_TextBox.Text.Equals(""))
            {
                score_TextBlock.Text = licz().ToString();
            }
            else
            {
                score_TextBlock.Text = score.ToString();
            }
        }

        private double licz()
        {
            double dystans = 0;
            double czas = 0;
            try
            {
                dystans = double.Parse(distance_TextBox.Text);
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

                czas = double.Parse(time_TextBox.Text);
                if (sprawdzCzas() == "Minutes")
                {
                    czas = czas / 60;
                }
                else if (sprawdzCzas() == "Seconds")
                {
                    czas = czas / 3600;
                }
            }
            catch (Exception ex){
                MessageBox.Show("Error has occured! " + ex.Message);
            }

            return dystans / czas;
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

        private void distance_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            float score = 0;
            if (!time_TextBox.Text.Equals("") && !distance_TextBox.Text.Equals(""))
            {
                score_TextBlock.Text = licz().ToString();
            }
            else
            {
                score_TextBlock.Text = score.ToString();
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (czyAkcja)
            {
                float score = 0;
                if (!time_TextBox.Text.Equals("") && !distance_TextBox.Text.Equals(""))
                {
                    score_TextBlock.Text = licz().ToString();
                }
                else
                {
                    score_TextBlock.Text = score.ToString();
                }
            }
        }

        private void ListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (czyAkcja)
            {
                float score = 0;
                if (!time_TextBox.Text.Equals("") && !distance_TextBox.Text.Equals(""))
                {
                    score_TextBlock.Text = licz().ToString();
                }
                else
                {
                    score_TextBlock.Text = score.ToString();
                }
            }

            czyAkcja = true;
 
        }
    }
}