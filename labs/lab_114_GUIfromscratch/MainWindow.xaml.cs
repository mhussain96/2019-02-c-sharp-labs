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
using System.IO;

namespace lab_114_GUIfromscratch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerList = new List<string>();
        Customer customer;

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
                ListBox02.ItemsSource = customers;
                ListBox02.DisplayMemberPath = "ContactName";
            }            
        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox02.SelectedItem;
            TextBoxName.Text = customer.ContactName;          
        }

        private void UpdateName_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                var customerUpdate = db.Customers.Where(c => c.ContactName == customer.ContactName).FirstOrDefault();

                if (!TextBoxName.Text.Equals("")) customerUpdate.ContactName = TextBoxName.Text;
                {
                    db.SaveChanges();
                }
            }
        }       
    }   
}
