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
    public partial class ConvertPage : PhoneApplicationPage
    {
        Boolean czyAkcja = false;
        public ConvertPage()
        {
            InitializeComponent();
        }

        private void yourSpeed_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double test;
            if (!Double.TryParse(yourSpeed_TextBox.Text, out test))
            {
                if (!yourSpeed_TextBox.Text.Equals(""))
                {
                    score_TextBlock.Text = "Correct the values!";
                }
            }
            else if (!yourSpeed_TextBox.Text.Equals(""))
            {
                score_TextBlock.Text = licz();
            }
            else
            {
                score_TextBlock.Text = "0";
            }

        }

        private void your_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            czyAkcja2();
        }

        private void con_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            czyAkcja2();
            czyAkcja = true;
        }

        private string licz()
        {
            double yourSpeed = double.Parse(yourSpeed_TextBox.Text);
            double wynik = 0;
            if (sprawdzYour().Equals("km/h"))
            {
                yourSpeed = yourSpeed * ((double)100000 / 3600);
            }
            else if (sprawdzYour().Equals("km/min"))
            {
                yourSpeed = yourSpeed * ((double)100000 / 60);
            }
            else if (sprawdzYour().Equals("km/s"))
            {
                yourSpeed = yourSpeed * ((double)100000);
            }
            else if (sprawdzYour().Equals("mph"))
            {
                yourSpeed = yourSpeed * (160934.4 / 3600);
            }
            else if (sprawdzYour().Equals("mpmin"))
            {
                yourSpeed = yourSpeed * (160934.4 / 60);
            }
            else if (sprawdzYour().Equals("mps"))
            {
                yourSpeed = yourSpeed * (160934.4);
            }
            else if (sprawdzYour().Equals("m/h"))
            {
                yourSpeed = yourSpeed * ((double)100 / 3600);
            }
            else if (sprawdzYour().Equals("m/min"))
            {
                yourSpeed = yourSpeed * ((double)100 / 60);
            }
            else if (sprawdzYour().Equals("m/s"))
            {
                yourSpeed = yourSpeed * ((double)100);
            }
            else if (sprawdzYour().Equals("cm/h"))
            {
                yourSpeed = yourSpeed / (double)3600;
            }
            else if (sprawdzYour().Equals("cm/min"))
            {
                yourSpeed = yourSpeed / (double)60;
            }
            else
            {
            }

            if (sprawdzCon().Equals("km/h"))
            {
                wynik = yourSpeed / ((double)100000 / 3600);
            }

            else if (sprawdzCon().Equals("km/min"))
            {
                wynik = yourSpeed / ((double)100000 / 60);
            }

            else if (sprawdzCon().Equals("km/s"))
            {
                wynik = yourSpeed / ((double)100000);
            }
            else if (sprawdzCon().Equals("mph"))
            {
                wynik = yourSpeed / (160934.4 / 3600);
            }
            else if (sprawdzCon().Equals("mpmin"))
            {
                wynik = yourSpeed / (160934.4 / 60);
            }
            else if (sprawdzCon().Equals("mps"))
            {
                wynik = yourSpeed / (160934.4);
            }
            else if (sprawdzCon().Equals("m/h"))
            {
                wynik = yourSpeed / ((double)100 / 3600);
            }
            else if (sprawdzCon().Equals("m/min"))
            {
                wynik = yourSpeed / ((double)100 / 60);
            }
            else if (sprawdzCon().Equals("m/s"))
            {
                wynik = yourSpeed / ((double)100);
            }
            else if (sprawdzCon().Equals("cm/h"))
            {
                wynik = yourSpeed * (double)3600;
            }
            else if (sprawdzCon().Equals("cm/min"))
            {
                wynik = yourSpeed * (double)60;
            }
            else
            {
                wynik = yourSpeed;
            }





            return Math.Round(wynik, 3).ToString();
        }

        private void czyAkcja2()
        {
            if (czyAkcja)
            {
                float score = 0;
                if (!yourSpeed_TextBox.Text.Equals(""))
                {
                    score_TextBlock.Text = licz();
                }
                else
                {
                    score_TextBlock.Text = score.ToString();
                }
            }
        }

        private string sprawdzYour()
        {
            ListBoxItem lbi = (ListBoxItem)your_ListBox.SelectedItem;
            return (string)lbi.Content;
        }
        private string sprawdzCon()
        {
            ListBoxItem lbi = (ListBoxItem)con_ListBox.SelectedItem;
            return (string)lbi.Content;
        }



    }
}