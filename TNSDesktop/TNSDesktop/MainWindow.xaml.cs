using Newtonsoft.Json;
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

namespace TNSDesktop
{
    public partial class MainWindow : Window
    {
     //   tnsEntities db = new tnsEntities();

      //  List<Staffs> rolesUser = new List<Staffs>();
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new AbonentPage();

            /*   Singlton.frame = MainFrame;
               Singlton.frame.Navigate(new AbonentPage());

               int i = 0;
               foreach (var item in db.Staffs.ToList())
               {
                   CbUsers.Items.Add(item.LastName + " " + item.FirstName + " " + item.LastName);
                   rolesUser.Add(item);
                   i++;
               }
               CbUsers.SelectedIndex = 0; */
        }

        private void CbUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         /*   var idR = rolesUser.ToArray()[CbUsers.SelectedIndex].IdRole;
            IUsers.Source = (this.FindName(rolesUser.ToArray()[CbUsers.SelectedIndex].PhotoPatch) as Image).Source;
            if (idR == 1)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Visible;
                BtnActive.Visibility = Visibility.Collapsed;
                BtnDeviceControl.Visibility = Visibility.Collapsed;
                BtnSupport.Visibility = Visibility.Collapsed;

                LbNews.Items.Add(new TextBlock()
                {
                    Text = "27 августа, собрание акционеров 12.00",

                });
                LbNews.Items.Add(new TextBlock()
                {
                    Text = "27 августа, 16.00 - формирование пакета документов на грант"
                });
                LbNews.Items.Add(new TextBlock()
                {
                    Text = "27 августа публикация на сайте о проекте"
                });
            }
            else if (idR == 2)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Collapsed;
                BtnActive.Visibility = Visibility.Collapsed;
                BtnDeviceControl.Visibility = Visibility.Collapsed;
                BtnSupport.Visibility = Visibility.Collapsed;
            }
            else if (idR == 3)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Collapsed;
                BtnActive.Visibility = Visibility.Collapsed;
                BtnDeviceControl.Visibility = Visibility.Visible;
                BtnSupport.Visibility = Visibility.Visible;
            }
            else if (idR == 4)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Collapsed;
                BtnActive.Visibility = Visibility.Collapsed;
                BtnDeviceControl.Visibility = Visibility.Visible;
                BtnSupport.Visibility = Visibility.Visible;
            }
            else if (idR == 5)
            {
                BtnCRM.Visibility = Visibility.Collapsed;
                BtnBilling.Visibility = Visibility.Visible;
                BtnActive.Visibility = Visibility.Visible;
                BtnDeviceControl.Visibility = Visibility.Collapsed;
                BtnSupport.Visibility = Visibility.Collapsed;
            }
            else if (idR == 6)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Visible;
                BtnActive.Visibility = Visibility.Visible;
                BtnDeviceControl.Visibility = Visibility.Visible;
                BtnSupport.Visibility = Visibility.Visible;
            }
            else if (idR == 7)
            {
                BtnCRM.Visibility = Visibility.Visible;
                BtnBilling.Visibility = Visibility.Collapsed;
                BtnActive.Visibility = Visibility.Visible;
                BtnDeviceControl.Visibility = Visibility.Visible;
                BtnSupport.Visibility = Visibility.Collapsed;
            } */
        }

        private void BtnActive_Click(object sender, RoutedEventArgs e)
        {
            // TbNamePage.Text = (sender as Button).Content.ToString();
            // Singlton.frame.Navigate(null);
        }

        private void BtnBilling_Click(object sender, RoutedEventArgs e)
        {
            //   TbNamePage.Text = (sender as Button).Content.ToString();
            //   Singlton.frame.Navigate(new Billing());
            MainFrame.Content = new Billing();
        }

        private void BtnSupport_Click(object sender, RoutedEventArgs e)
        {
            //   TbNamePage.Text = (sender as Button).Content.ToString();
            //  Singlton.frame.Navigate(new SupportPage());
            MainFrame.Content = new SupportPage();
        }

        private void BtnCRM_Click(object sender, RoutedEventArgs e)
        {
         //   TbNamePage.Text = (sender as Button).Content.ToString();
        //    Singlton.frame.Navigate(null);

        }

        private void BtnAbonent_Click(object sender, RoutedEventArgs e)
        {
            //  TbNamePage.Text = (sender as Button).Content.ToString() + " ТНС";
            //   Singlton.frame.Navigate(new AbonentPage());
            MainFrame.Content = new AbonentPage();
        }

        private void BtnDeviceControl_Click(object sender, RoutedEventArgs e)
        {
            //  TbNamePage.Text = (sender as Button).Content.ToString();
            //  Singlton.frame.Navigate(new ControlStatePage());
            MainFrame.Content = new ControlStatePage();
        }
    }
}
