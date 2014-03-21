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

namespace Homework2
{
    public partial class MainPage : PhoneApplicationPage
    {
       
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void zapisz_Button_Click(object sender, RoutedEventArgs e)
        {
            Agent agent = new Agent();
            agent.imie = name_TextBox.Text;
            agent.undercover = under_ChekBox.IsChecked;

            if (CIA_RadioButton.IsChecked == true)
            {
                agent.agency = "CIA"; 
            }
            else if (MI6_RadioButton.IsChecked == true)
            {
                agent.agency = "MI6";
            }
            else
            {
                agent.agency = "CIA";
            }

            ListBoxItem lbi = (ListBoxItem)prefer_ListBox.SelectedItem;
            agent.proficiencies = (string)lbi.Content;
            drukuj(agent);
        }

        private void czysc_Button_Click(object sender, RoutedEventArgs e)
        {
            name_TextBox.Text = "";
            under_ChekBox.IsChecked = false;
            CIA_RadioButton.IsChecked = false;
            MI6_RadioButton.IsChecked = false;
            CIA_RadioButton.IsChecked = false;
            prefer_ListBox.SelectedItem = null;
        }

        private void drukuj(Agent agent)
        {
            wynik_TextBlock.Text = "Imię: " + agent.imie + "\nUndercover: " + agent.undercover + "\nAgency: " + agent.agency + "\nProf:" + agent.proficiencies;
        }
     
    }
}