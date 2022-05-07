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
    public partial class Save1 : Form
    {
       // SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-5E81T14P;Initial Catalog=Game;Integrated Security=True");

        public Save1()
        {
            InitializeComponent();
        }

        private void Save1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gameDataSet3.Save". При необходимости она может быть перемещена или удалена.
         //   this.saveTableAdapter.Fill(this.gameDataSet3.Save);
          
            
       /*     connection.Open();
            label1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            label3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); */

            if (textBox1.Text == "")
            {
                zad1.Visible = true;
                btzad1.Visible = true;
            }
    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saves sv = new Saves();
            sv.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btzad1_Click(object sender, EventArgs e)
        {
            zad1.Visible = false;
            btzad1.Visible = false;
            zad1_1.Visible = true;
            btzad2.Visible = true;
            pictureBox1.Visible = true;
        }

        private void btzad2_Click(object sender, EventArgs e)
        {
            zad1_1.Visible = false;
            btzad2.Visible = false;
            pictureBox1.Visible = false;
            zad1_2.Visible = true;
            btzad3.Visible = true;
        }

        private void btzad3_Click(object sender, EventArgs e)
        {
          /*  SqlCommand command = new SqlCommand("UPDATE [Save] SET Danie = 200 Where Id_Save = 1", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сохранено");*/
            zad1_2.Visible = false;
            btzad3.Visible =false; 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   SqlCommand command = new SqlCommand("SELECT *  FROM [Save]", connection);
            command.ExecuteNonQuery();*/

            label3.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); 
        }
    }
}
