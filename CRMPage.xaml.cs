﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для CRMPage.xaml
    /// </summary>
    public partial class CRMPage : Page
    {
    //    SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Neva;Integrated Security=True");
        public CRMPage()
        {
            InitializeComponent();
         //   connection.Open();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}