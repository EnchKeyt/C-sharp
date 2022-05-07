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
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo10DataSet.Материалы_на_складе". При необходимости она может быть перемещена или удалена.
           // this.материалы_на_складеTableAdapter.Fill(this.wsdemo10DataSet.Материалы_на_складе);

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Glavnaya form2 = new Glavnaya();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ой, что-то пошло не так");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ой, что-то пошло не так");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ой, что-то пошло не так");
        }
    }
}
