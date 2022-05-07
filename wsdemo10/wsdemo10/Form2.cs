using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsdemo10
{
    public partial class Glavnaya : Form
    {
        public Glavnaya()
        {
            InitializeComponent();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            ExitForm f6 = new ExitForm();
            f6.Show();
            
            
        }

        private void product_btn_Click(object sender, EventArgs e)
        {
            Materials f3 = new Materials();
            f3.Show();
            this.Hide();
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
            Product f4 = new Product();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageProduct f5 = new ImageProduct();
            f5.Show();
            this.Close();
        }

        private void Glavnaya_Load(object sender, EventArgs e)
        {

        }
    }

}
