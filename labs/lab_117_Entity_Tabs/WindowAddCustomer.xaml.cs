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

namespace lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for WindowAddCustomer.xaml
    /// </summary>
    public partial class WindowAddCustomer : Window
    {
        public WindowAddCustomer()
        {
            InitializeComponent();
        }

        static List<Customer> customers = new List<Customer>();

        private void TextBoxInsert_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (var db = new NorthwindEntities())
            {
                Customer customerToCreate = new Customer { ContactName = " " };

                db.Customers.Add(customerToCreate);

               
            }          
        }
    }


}
