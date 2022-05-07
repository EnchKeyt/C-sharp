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
    public partial class ImageProduct : Form
    {
        public ImageProduct()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo10DataSet.Продукты". При необходимости она может быть перемещена или удалена.
          //  this.продуктыTableAdapter.Fill(this.wsdemo10DataSet.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo10DataSet.Продукт". При необходимости она может быть перемещена или удалена.
         //   this.продуктTableAdapter.Fill(this.wsdemo10DataSet.Продукт);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Glavnaya form2 = new Glavnaya();
            form2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Увы, но это действие не удалось");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Увы, но это действие не удалось");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Увы, но это действие не удалось");
        }
    }
}
