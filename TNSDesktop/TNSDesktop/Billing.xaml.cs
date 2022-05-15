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
    public partial class Billing : Page
    {
       /* tnsEntities db = new tnsEntities();
        List<DataAbonent> dataAbonents = new List<DataAbonent>(); */
        public Billing()
        {
            InitializeComponent();

           /* TbDate.Text = DateTime.Now.ToString("d");
            foreach (var item in db.Services.ToList())
            {
                CbServices.Items.Add(item.Name);
            }

            UpdateDAbonent();
            DgDataAbonent.ItemsSource = dataAbonents; */
        }

        private void CbServices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          /*  UpdateDAbonent();
            dataAbonents.Where(x => x.tarif.Services.Name.StartsWith(CbServices.SelectedItem.ToString()));
            DgDataAbonent.ItemsSource = null;
            DgDataAbonent.ItemsSource = dataAbonents; */
        }
        private void UpdateDAbonent()
        {
         /*   Random random = new Random();
            dataAbonents = new List<DataAbonent>();
            foreach (var item in db.Abonents.ToList().Where(x => x.CommentDestroyDoc == ""))
            {
                DataAbonent dataAbonent = new DataAbonent()
                {
                    Ls = item.LS,
                    tarif = db.Tarifs.ToArray()[random.Next(0, db.Tarifs.ToList().Count - 1)]
                };
                dataAbonent.dolg = Convert.ToDouble(dataAbonent.tarif.Price) * random.Next(0, 4) + "";
                dataAbonents.Add(dataAbonent);
            } */
        }
    }
    public class DataAbonent
    {
        public string Ls { get; set; }
        public Tarifs tarif { get; set; }
        public string dolg { get; set; }
    }
}
