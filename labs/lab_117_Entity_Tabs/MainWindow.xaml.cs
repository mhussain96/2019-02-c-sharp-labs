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

namespace lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        //List<string> customerList = new List<string>();
        Customer customer;

        List<Order> orders = new List<Order>();
        //List<string> orderList = new List<string>();
        Order order;

        List<Order_Detail> order_details = new List<Order_Detail>();
        //List<string> orderDetailList = new List<string>();
        Order_Detail order_detail;

        List<Product> products = new List<Product>();
        //List<string> productList = new List<string>();
   
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

                customerListBox.ItemsSource = customers;
                customerListBox.DisplayMemberPath = "ContactName";

            }
        }

        private void ButtonChangeTab_Click(object sender, RoutedEventArgs e)
        {
            if (TabControl01.SelectedIndex < TabControl01.Items.Count - 1)
            {
                TabControl01.SelectedIndex++;
            }
            else
            {
                TabControl01.SelectedIndex = 0;
            }
        }
        // enum is structure which maps names to numbers
        // days of week 0 = sunday 6 = saturday
        // months 0 = january
        // enum automatically sets first = 0, second = 1, third = (same as TabIndex)
        enum tabs
        {
            First,
            Second,
            Third
        }

        private void CustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)customerListBox.SelectedItem;

            using (var db = new NorthwindEntities())
            {
                orders = db.Orders.Where(o => o.CustomerID==customer.CustomerID).ToList<Order>();

                customerListBox01.ItemsSource = orders;

                customerListBox01.DisplayMemberPath = "OrderID";
            }
        }

        private void CustomerListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            order = (Order)customerListBox01.SelectedItem;

            using (var db = new NorthwindEntities())
            {
                order_details = db.Order_Details.Where(od => od.OrderID == order.OrderID).ToList<Order_Detail>();

                customerListBox02.ItemsSource = order_details;

                customerListBox02.DisplayMemberPath = "ProductID";
            }
        }

        private void CustomerListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            order_detail = (Order_Detail)customerListBox02.SelectedItem;

            using (var db = new NorthwindEntities())
            {
                products = db.Products.Where(p => p.ProductID == order_detail.ProductID).ToList<Product>();

                customerListBox03.ItemsSource = products;

                customerListBox03.DisplayMemberPath = "ProductName";
            }
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void ButtonWindowChange_Click(object sender, RoutedEventArgs e)
        {
            var newW = new Window();
            newW.Visibility = Visibility.Visible;

            var windowaddcustomer = new WindowAddCustomer();
            windowaddcustomer.Visibility = Visibility.Visible;
        }

        // for mousedouble click you must add MouseDoubleClick to the xaml and add it to the box you want to assign it to


        //private void customerList01_MouseDoubleClick(object sender, SelectionChangedEventArgs e)
        //{
        //    customer = (Customer)customerListBox.SelectedItem;
        //    TabControl01.SelectedIndex = (int)tabs.Second;
        //    using (var db = new NorthwindEntities())
        //    {
        //        orders =
        //            db.Orders
        //            .Where(order => order.CustomerID == customer.CustomerID)
        //            .ToList<Order>();
        //        customerListBox01.ItemsSource = orders;
        //    }
        //}
    }
}
