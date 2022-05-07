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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         Abonent.Navigate(new AbonentPage());
            
        }

        private void Abonent_ContentRendered(object sender, EventArgs e)
        {
            
        }

        private void CRM_Click(object sender, RoutedEventArgs e)
        {
            Abonent.Navigate(new CRMPage());
            
        }

        private void Upr_Click(object sender, RoutedEventArgs e)
        {
            Abonent.Navigate(new UpravleniePage());
        }

        private void Pod_Click(object sender, RoutedEventArgs e)
        {
            Abonent.Navigate(new PodderzkaPage());
        }
    }
}
