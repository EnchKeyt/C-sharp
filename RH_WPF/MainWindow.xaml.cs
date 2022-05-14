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

namespace RH_WPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.AbonentsPage());
        }

        private void UprOborudButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.UpravlenOborudovaniem());
        }

        private void AbonentButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.AbonentsPage());
        }

        private void CRMButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.CRMPage());
        }

        private void PodderzkaPolzovButton_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.PodderzkaPolzovateleyPage());
        }

        private void Billing_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new PageTelekom.BillingPage());
        }
    }
}
