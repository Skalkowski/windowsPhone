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

        private String licz()
        {
           
            try
            {
                double dystans = 0;
                double czas = 0;
                double wynik = 0;
                dystans = double.Parse(distance_TextBox.Text);
                if (sprawdzDystans() == "Kilometers")
                {
                    dystans = dystans * 1000;
                }
                else if (sprawdzDystans() == "Miles")
                {
                    dystans = dystans * 1609.344;
                }
                else if (sprawdzDystans() == "Centimeters")
                {
                    dystans = dystans / 100;
                }
                czas = double.Parse(time_TextBox.Text);
                if (sprawdzCzas() == "Hours")
                {
                    czas = czas * 60;
                }
                else if (sprawdzCzas() == "Seconds")
                {
                    czas = czas / 60;
                }

                if (sprawdzWynik() == "km/h")
                {
                    wynik = (dystans / 1000) / (czas / 60);
                }
                else if (sprawdzWynik() == "mph")
                {
                    wynik = (dystans / 1609.344) / (czas / 60);
                }
                else
                {
                    wynik = dystans / czas;
                }
                return Math.Round(wynik,3).ToString();
            }
            catch
            {
                return "Correct the values!";
            }
        }
        private void all_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double test;

            if (!Double.TryParse(time_TextBox.Text, out test) || !Double.TryParse(distance_TextBox.Text, out test))
            {
                if (!time_TextBox.Text.Equals(""))
                {
                    score_TextBlock.Text = "Correct the values!";
                }
            }
            else if (!time_TextBox.Text.Equals("") && !distance_TextBox.Text.Equals(""))
            {
                score_TextBlock.Text = licz().ToString();
            }
            else
            {
                score_TextBlock.Text = "0";
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            czyAkcja2();
        }

        private void ListBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            czyAkcja2();

            czyAkcja = true;
        }

        private void czyAkcja2()
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

        private string sprawdzWynik()
        {
            ListBoxItem lbi = (ListBoxItem)score_ListBox.SelectedItem;
            return (string)lbi.Content;
        }

        private void back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void clear_Button_Click(object sender, RoutedEventArgs e)
        {
            distance_TextBox.Text = "";
            time_TextBox.Text = "";
            score_TextBlock.Text = "0";
        }
    }
}