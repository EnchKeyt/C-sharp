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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo10DataSet.Продукция". При необходимости она может быть перемещена или удалена.
          //  this.продукцияTableAdapter.Fill(this.wsdemo10DataSet.Продукция);

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Glavnaya f2 =new Glavnaya();
            f2.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проблемка! Похоже действие не удалось");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проблемка! Похоже действие не удалось");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проблемка! Похоже действие не удалось");
        }
    }
}
