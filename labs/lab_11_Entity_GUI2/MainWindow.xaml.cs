﻿using System;
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
        }
    }
}
