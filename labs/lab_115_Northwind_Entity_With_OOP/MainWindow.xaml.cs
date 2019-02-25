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
using System.Diagnostics;

namespace lab_115_Northwind_Entity_With_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Lab 115 
    /// 
    /// Read customers and (cast) to ActiveCustomers and 
    /// set IsActive to true for all customers
    /// 
    /// create 2 listboxes and a radio button to enable/disable 
    /// our ActiveCustomer
    /// 
    /// Click on Customer to select and display all details on the screen (TextBlock, StackPanel, Listbox2)
    /// 
    /// when you click on the enable/disable button the IsActive changes (toggles) state 
    /// 
    /// First listbox = only for Active Customers 
    ///          state becomes inactive ==> remove from first listbox 
    /// 
    /// second listbox = only inactive customers 
    ///         inactive state : remove from first but to second listbox
    ///         
    /// reverse the process ie when you click on Inactive Customer (second listbox) it you can then toggle the state back to enable
    /// (use the radio or toggle button).
    /// removed from Inactive and add back to Active list
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
            
        }

        List<Customer> allCustomers = new List<Customer>();
        List<ActiveCustomer> Active = new List<ActiveCustomer>();
        List<ActiveCustomer> InActive = new List<ActiveCustomer>();

        void Initialize()
        {
            using (var db = new NorthwindEntities())
            {
                allCustomers = db.Customers.ToList();
            }
        }
        // interface is like a tool you can use/implement
        interface IDoThis
        {
            void DoThis();
        }
        
        interface IDoThat
        {
            void DoThat();
        }

        // we already have class customer 
        // class ActiveCustomer : Customer 
        class ActiveCustomer : Customer, IDoThis, IDoThat // inheritance
        {
            public bool IsActive;

            public void DoThis()
            {

            }

            public void DoThat()
            {

            }

            public ActiveCustomer(Customer c)
            {
                Address = c.Address;
                City = c.City;
                ContactName = c.ContactName;
                CompanyName = c.CompanyName;
                ContactTitle = c.ContactTitle;
                Country = c.Country;
                CustomerID = c.CustomerID;
                Fax = c.Fax;
                Phone = c.Phone;
                PostalCode = c.PostalCode;
                Region = c.Region;
                IsActive = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }

    //public partial class Customer
    //{
    //    // extend here if you want
    //    // add other fields here if wanted 
    //    public void DoThis()
    //    {
    //        // This class cannot be inherited
    //        Trace.WriteLine("Customer is doing something");
    //    }
    //}
}
