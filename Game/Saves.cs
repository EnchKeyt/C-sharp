using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Game
{
    public partial class Saves : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-5E81T14P;Initial Catalog=Game;Integrated Security=True");
        public Saves()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Saves_Load(object sender, EventArgs e)
        {
            connection.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand check = new SqlCommand("SELECT * FROM [Save] where Id_Save =  1", connection);
           check.ExecuteNonQuery(); ;
            if (check.ExecuteScalar() != null)
            {
                Save1 sv = new Save1();
                sv.Show();
                Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Создать сохранение?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button1.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    textBox2.Visible = true;
                    button7.Visible = true;
                    label1.Visible = false;
                    label2.Visible = true;

                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlCommand check = new SqlCommand("SELECT * FROM [Save] where Id_Save =  2", connection);
            check.ExecuteNonQuery(); 
            if (check.ExecuteScalar() != null)
            {
                Save2 sv = new Save2();
                sv.Show();
                Hide();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Создать сохранение?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    button1.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    textBox2.Visible = true;
                    button6.Visible = true;
                    label1.Visible = false;
                    label2.Visible =true;
                }
                else if (dialogResult == DialogResult.No)
                {
                
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Save](Polzovstel) VALUES ('" + textBox2.Text+"')", connection);
            
            
            command.ExecuteNonQuery();
            MessageBox.Show("Сохранение выполнено");
            Save2 sv = new Save2();
            sv.Show();
            Hide();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Save](Polzovstel) VALUES (N'" + textBox2.Text + "')", connection);


            command.ExecuteNonQuery();
            MessageBox.Show("Сохранение выполнено");
            Save1 sv = new Save1();
            sv.Show();
            Hide();

        }
    }
}
