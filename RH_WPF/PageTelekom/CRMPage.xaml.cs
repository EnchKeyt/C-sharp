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
    /// Логика взаимодействия для CRMPage.xaml
    /// </summary>
    public partial class CRMPage : Page
    {
       // ws05Entities db;
        public CRMPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
        
private void Proverit_Click(object sender, RoutedEventArgs e)
        {
            /*  db = new ws05Entities();
           db.AllAbonts.Load();


           AllAbonts allAbonts = db.AllAbonts.Where(x => x.Номер_телефона == textBoxNomer.Text && x.ФИО == textBoxFIO.Text).FirstOrDefault(); */
            if ((textBoxNomer.Text == "1" && textBoxFIO.Text == "1") == true)//allAbonts != null)
            {
                MessageBox.Show("Абонент найден");
                frame.Content = new PageTelekom.CRmPolzovatel();//allAbonts.ИД.ToString());
            }
            else
            {
                MessageBox.Show("Абонент не найден");
            }
        }
    }
        
}
