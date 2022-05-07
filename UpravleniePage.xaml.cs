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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для UpravleniePage.xaml
    /// </summary>
    public partial class UpravleniePage : Page
    {
        public UpravleniePage()
        {
            InitializeComponent();
          //  DGAbonent.ItemsSource = NevaEntities7.GetContext().Oborudovanir.ToList();

        }

        private void Kontrol_Click(object sender, RoutedEventArgs e)
        {
           
        }

  

        private void Abon_Selected(object sender, RoutedEventArgs e)
        {
            DGAbonent.Visibility=Visibility;
        }

        private void B_Checked(object sender, RoutedEventArgs e)
        {

            Combo.Visibility = Visibility.Collapsed;
            DGAbonent.Visibility = Visibility;
        }

        private void Button_Checked(object sender, RoutedEventArgs e)
        {
            Combo.Visibility = Visibility;
            DGAbonent.Visibility = Visibility.Collapsed;
        }
    }
}
