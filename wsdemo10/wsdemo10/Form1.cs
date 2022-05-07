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
    public partial class Aftorization : Form
    {
        public Aftorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "admin"&& textBox2.Text == "pass") 
              //  {
                    Glavnaya f2 = new Glavnaya();
                    f2.Show();
                    this.Hide();
               // }
            //else 
              //      MessageBox.Show("Неправильный логин или пароль");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            ExitForm f6 = new ExitForm();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         //  textBox2.UseSystemPasswordChar = true;
        }

        private void Aftorization_Load(object sender, EventArgs e)
        {

        }
    }
}

