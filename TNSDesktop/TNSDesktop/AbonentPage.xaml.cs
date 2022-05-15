using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public partial class AbonentPage : Page
    {
      //  tnsEntities db = new tnsEntities();
        public AbonentPage()
        {
            InitializeComponent();

          /*  db.Abonents.Load();
            DgAbonent.ItemsSource = db.Abonents.Local.ToBindingList(); */
        }
    }
}
