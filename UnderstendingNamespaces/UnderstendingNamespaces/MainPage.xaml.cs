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
using System.IO.IsolatedStorage;

namespace UnderstendingNamespaces
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Car car1 = new Car();
            car1.Make = "Kia";
            car1.Model = "Sportage";

            Car car2 = new Car();
            car2.Make = "Jeep";
            car2.Model = "Grand Cheeroke";

            Car car3 = new Car() { Make = "Ford", Model = "Windstar" };

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            myList.Add(car3);

            textBlock1.Text = drukuj(myList);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<Car> List2 = new List<Car>()
            {
                new Car { Make = "Audi", Model = "A5" },
                new Car { Make = "Fiat", Model = "125p" },
                new Car { Make = "Honda", Model = "Civic"}
            };

           
            textBlock1.Text = drukuj(List2);

        }

        public String drukuj(List<Car> lista)
        {
            string myCars = "";
            foreach (Car car in lista)
            {
                myCars += car.Make + " " + car.Model + "\n";
            }
            return myCars;
        }
    }
}