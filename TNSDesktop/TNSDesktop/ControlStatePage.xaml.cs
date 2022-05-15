using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    public partial class ControlStatePage : Page
    {
      //  tnsEntities db = new tnsEntities();
        public ControlStatePage()
        {
            InitializeComponent();

         /*   foreach (var item in db.Magistrals.ToList())
            {
                LbMagistralDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }
            foreach (var item in db.LineDevices.ToList())
            {
                LbLineDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }
            foreach (var item in db.AbonentDevices.ToList())
            {
                LbAbonentDevices.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            } */
        }
        private void LbMagistralDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         /*   if ((LbMagistralDevice.SelectedItem as TextBlock) == null)
            {
                return;
            }

            WebClient webClient = new WebClient();
            
            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber=" 
                + (LbMagistralDevice.SelectedItem as TextBlock).Text);

            if (result == "0")
            {
                (LbMagistralDevice.SelectedItem as TextBlock).Background = CRed.Background;
            }
            else
            {
                (LbMagistralDevice.SelectedItem as TextBlock).Background = null;
            } */
        }
        private void LbLineDevice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         /*   if ((LbLineDevice.SelectedItem as TextBlock) == null)
            {
                return;
            }
            WebClient webClient = new WebClient();

            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
                + (LbLineDevice.SelectedItem as TextBlock).Text);

            if (result == "0")
            {
                (LbLineDevice.SelectedItem as TextBlock).Background = CRed.Background;
            }
            else
            {
                (LbLineDevice.SelectedItem as TextBlock).Background = null;
            } */
        }
        private void LbAbonentDevices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         /*   if ((LbAbonentDevices.SelectedItem as TextBlock) == null)
            {
                return;
            }

            WebClient webClient = new WebClient();

            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
                + (LbAbonentDevices.SelectedItem as TextBlock).Text);
            if (result == "0")
            {
                (LbAbonentDevices.SelectedItem as TextBlock).Background = CRed.Background;
            }
            else
            {
                (LbAbonentDevices.SelectedItem as TextBlock).Background = null;
            } */
        }
        private void UpdateStatusDevices_Click(object sender, RoutedEventArgs e)
        {
        /*    WebClient webClient = new WebClient();
            foreach (var item in LbMagistralDevice.Items)
            {
                TextBlock tb = item as TextBlock;
                var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
                + tb.Text);

                if (result == "0")
                {
                    tb.Background = CRed.Background;
                }
                else
                {
                    tb.Background = null;
                }
            }
            foreach (var item in LbLineDevice.Items)
            {
                TextBlock tb = item as TextBlock;
                var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
                + tb.Text);

                if (result == "0")
                {
                    tb.Background = CRed.Background;
                }
                else
                {
                    tb.Background = null;
                }
            }
            foreach (var item in LbAbonentDevices.Items)
            {
                TextBlock tb = item as TextBlock;
                var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
                + tb.Text);

                if (result == "0")
                {
                    tb.Background = CRed.Background;
                }
                else
                {
                    tb.Background = null;
                }
            } */
        }
        private void LbMagistralDevice_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
         /*   TextBlock tb = LbMagistralDevice.SelectedItem as TextBlock;
            var deviceInfo = db.Magistrals.ToList().FirstOrDefault(x => x.SerNumber == tb.Text);
            MessageBox.Show("Название: " + deviceInfo.Name + "\nЧастота:" + deviceInfo.Chast 
                + "\nКоэффициент затухания:" + deviceInfo.CaefZatyx
                + "\nТехнология передачи данных:" + deviceInfo.TehMoveData
                + "\nРасположение" + deviceInfo.Location
                );


            WebClient webClient = new WebClient();
            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
            + tb.Text);

            if (result == "0")
            {
                tb.Background = CRed.Background;
            }
            else
            {
                tb.Background = null;
            }

        }
        private void LbLineDevice_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = LbLineDevice.SelectedItem as TextBlock;
            var deviceInfo = db.LineDevices.ToList().FirstOrDefault(x => x.SerNumber == tb.Text);
            MessageBox.Show("Название: " + deviceInfo.Name 
                + "\nКоличество портов:" + deviceInfo.Port
                + "\nCтандарт передачи данных:" + deviceInfo.StandartMoveData
                + "\nЧастота:" + deviceInfo.Chast
                + "\nИнтерфейсы:" + deviceInfo.Interfaces
                + "\nСкорость передачи данных:" + deviceInfo.SpeedMoveData
                + "\nМесто расположения:" + deviceInfo.Location
                );


            WebClient webClient = new WebClient();
            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
            + tb.Text);

            if (result == "0")
            {
                tb.Background = CRed.Background;
            }
            else
            {
                tb.Background = null;
            } */
        }
        private void LbAbonentDevices_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
        /*    TextBlock tb = LbAbonentDevices.SelectedItem as TextBlock;
            var deviceInfo = db.AbonentDevices.ToList().FirstOrDefault(x => x.SerNumber == tb.Text);
            MessageBox.Show("Название: " + deviceInfo.Name
                + "\nКоличество портов:" + deviceInfo.Ports
                + "\nCтандарт передачи данных:" + deviceInfo.StandartMove
                + "\nСкорость передачи данных:" + deviceInfo.Speed
                + "\nАдрес абонента:" + deviceInfo.Location
                );


            WebClient webClient = new WebClient();
            var result = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state/?serialNumber="
            + tb.Text);

            if (result == "0")
            {
                tb.Background = CRed.Background;
            }
            else
            {
                tb.Background = null;
            } */
        }
        private void TbFindNameDevice_TextChanged(object sender, TextChangedEventArgs e)
        {
          /*  var magistrals = db.Magistrals.ToList().FindAll(x => x.Name.StartsWith((sender as TextBox).Text) == true);

            LbMagistralDevice.SelectedItem = null;
            LbMagistralDevice.Items.Clear();

            foreach (var item in magistrals.ToList())
            {
                LbMagistralDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }

            var lineDevices = db.LineDevices.ToList().FindAll(x => x.Name.StartsWith((sender as TextBox).Text) == true);

            LbLineDevice.SelectedItem = null;
            LbLineDevice.Items.Clear();

            foreach (var item in lineDevices.ToList())
            {
                LbLineDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }
            var abonentDevice = db.AbonentDevices.ToList().FindAll(x => x.Name.StartsWith((sender as TextBox).Text) == true);

            LbAbonentDevices.SelectedItem = null;
            LbAbonentDevices.Items.Clear();

            foreach (var item in abonentDevice.ToList())
            {
                LbAbonentDevices.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            } */
        }
        private void TbFindLocationDevice_TextChanged(object sender, TextChangedEventArgs e)
        {
          /*  var magistrals = db.Magistrals.ToList().FindAll(x => x.Location.StartsWith((sender as TextBox).Text) == true);

            LbMagistralDevice.SelectedItem = null;
            LbMagistralDevice.Items.Clear();

            foreach (var item in magistrals.ToList())
            {
                LbMagistralDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }

            var lineDevices = db.LineDevices.ToList().FindAll(x => x.Location.StartsWith((sender as TextBox).Text) == true);

            LbLineDevice.SelectedItem = null;
            LbLineDevice.Items.Clear();

            foreach (var item in lineDevices.ToList())
            {
                LbLineDevice.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }
            var abonentDevice = db.AbonentDevices.ToList().FindAll(x => x.Location.StartsWith((sender as TextBox).Text) == true);

            LbAbonentDevices.SelectedItem = null;
            LbAbonentDevices.Items.Clear();

            foreach (var item in abonentDevice.ToList())
            {
                LbAbonentDevices.Items.Add(new TextBlock()
                {
                    Text = item.SerNumber
                });
            }*/
        }
    }
}
