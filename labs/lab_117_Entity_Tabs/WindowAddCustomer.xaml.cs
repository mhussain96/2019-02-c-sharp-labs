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
using System.Windows.Shapes;
using System.Data.Sql;
using System.Data.SqlClient;

namespace lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for WindowAddCustomer.xaml
    /// </summary>
    /// 
    //Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

    public partial class WindowAddCustomer : Window
    {
        //SqlConnection con;
        //SqlCommand cmd;
        //SqlDataAdapter da;

        public WindowAddCustomer()
        {
            InitializeComponent();
        }

        static List<Customer> customers = new List<Customer>();

        private void TextBoxInsert_TextChanged(object sender, TextChangedEventArgs e)
        {
                   
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer
                {
                    CustomerID = TextBox1.Text,
                    ContactName = TextBox2.Text,
                    City = TextBox3.Text,
                    CompanyName = TextBox4.Text
                };
                // add new customer to local database 
                db.Customers.Add(customerToCreate);
                // write changes permanently to real database 
                db.SaveChanges();
            }
        }
    }
}
