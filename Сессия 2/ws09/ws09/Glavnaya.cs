using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ws09
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void Dlavnaya_Load(object sender, EventArgs e)
        {
           
        }

        private void mater_Click(object sender, EventArgs e)
        {
            //Переход на форма с материалами(Material)
            Material mater = new Material();
            mater.Show();
            Hide();
        }

        private void Postav_Click(object sender, EventArgs e)
        {
            Postavhiki postav = new Postavhiki();
            postav.Show();
            Hide();
        }
    }
}
