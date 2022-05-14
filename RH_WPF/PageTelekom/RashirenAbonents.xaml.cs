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

namespace RH_WPF.PageTelekom
{
    /// <summary>
    /// Логика взаимодействия для RashirenAbonents.xaml
    /// </summary>
    public partial class RashirenAbonents : Window
    {
        public RashirenAbonents()
        {
            InitializeComponent();
            /* AllAbonts allAbonts = ws05Entities.GetContext().AllAbonts.Where(x => x.ИД == id).FirstOrDefault();

          IdAbonts.Text = allAbonts.ИД.ToString();
              Nomer_abon.Text = allAbonts.Номер_абонента.ToString();
              FIO.Text = allAbonts.ФИО.ToString();

              Pol.Text = allAbonts.Пол.ToString();
              dateRozden.Text = allAbonts.Дата_рождения.ToString();
              nomerTel.Text = allAbonts.Номер_телефона.ToString();
              email.Text = allAbonts.Электронная_почта.ToString();
              adressPropis.Text = allAbonts.Адрес_прописки.ToString();
              adressProzhiv.Text = allAbonts.Адрес_проживания.ToString();
              pasport.Text = allAbonts.Серия_и_номер_паспорта.ToString();
              kod_podrazdel.Text = allAbonts.Код_подразделения.ToString();
              vidan.Text = allAbonts.Кем_выдан.ToString();
              dateVidachi.Text = allAbonts.Дата_выдачи_паспорта.ToString();
              nomerDogovor.Text = allAbonts.Номер_договора.ToString();
              DateZaklutch.Text = allAbonts.Дата_заключения_договора.ToString();
              tipDogovor.Text = allAbonts.Тип_договора.ToString();     
              LS.Text = allAbonts.Лицевой_счет.ToString();
              uslugi.Text = allAbonts.Услуги.ToString();           
              gateRastorzen.Text = allAbonts.Дата_расторжения_договора.ToString();        
              SerNomer.Text = allAbonts.Серийный_номер_оборудования.ToString(); */
        }
        private void SerNomer_SelectionChanged(object sender, RoutedEventArgs e)
        {
            //  WebClient webClient = new WebClient();
        }

        private void SerNomer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*  var webClient = new WebClient();

              try
              {
                  var response = webClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + SerNomer.Text);
                  if(response == "1")
                  {
                      MessageBox.Show("Оборудование работает");
                  }
                  else
                  {
                      MessageBox.Show("Оборудование не работает");
                  }
              }
              catch
              {
                  MessageBox.Show("Оборудование не найдено");
              } */
        }
    }
}
