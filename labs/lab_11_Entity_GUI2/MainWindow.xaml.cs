using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace lab_11_Entity_GUI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        // string x = "hi";
        // int y = 1; declare (string x) and initialise (="hi")
        Customer customer;
        List<String> cities = new List<String>(); 

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();

                foreach (var c in customers)
                {
                    customerList.Add($"{c.ContactName} had ID {c.CustomerID}");
                }
                ListBox01.ItemsSource = customerList;
            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();               
                ListBox02.ItemsSource = customers;               
            }

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox03.ItemsSource = customers;
                ListBox03.DisplayMemberPath = "ContactName";
            }

            // populate static combo
            ComboBoxStaticCity.Items.Add("New York");
            ComboBoxStaticCity.Items.Add("Paris");
            ComboBoxStaticCity.Items.Add("Milan");


            using (var db = new NorthwindEntities())
            {
                cities =
                    (from cust in db.Customers
                     select cust.City).Distinct().OrderBy(city=>city).ToList<string>();
                ComboBoxBoundToCity.ItemsSource = cities;
            }
        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox03.SelectedItem;
            TextBoxName.Text = customer.ContactName;
        }

        private void ComboBoxBoundToCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBoxStaticCity_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show($"You chose {ComboBoxStaticCity.SelectedItem}");
        }
    }
}
