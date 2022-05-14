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

namespace RH_WPF.PageTelekom
{
    /// <summary>
    /// Логика взаимодействия для AbonentsPage.xaml
    /// </summary>
    public partial class AbonentsPage : Page
    {
       // ws05Entities db;
        public AbonentsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
          
             // AbonentsGrid.ItemsSource = ws05Entities.GetContext().AllAbonts.ToList(); 
        }

        private void AbonentsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void NeAktivRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //    db = new ws05Entities();


            //  AbonentsGrid.ItemsSource = db.AllAbonts.Where(x => x.Дата_расторжения_договора != null).ToList();

        }

        private void AktivnRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //   db = new ws05Entities();
            //  AbonentsGrid.ItemsSource = db.AllAbonts.Where(x => x.Дата_расторжения_договора == null).ToList();
        }

        private void VseRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //      AbonentsGrid.ItemsSource = ws05Entities.GetContext().AllAbonts.ToList();
        }

        private void AbonentsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*      DataGrid dataGrid = (DataGrid)sender;
                  if(dataGrid.SelectedItem is AllAbonts allAbonts)
                  {
                      RashirAbonent rashirAbonent = new RashirAbonent(allAbonts.ИД);

                      rashirAbonent.Show();
                  } */
        }
    }
}
