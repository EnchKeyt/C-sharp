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

namespace OOO_Telecom_Neva_Svyaz
{
    public partial class PodderzkaPolzovatey : Form
    {
      //  SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws02;Persist Security Info=True;User ID=ws02;Password=2/G%raq№");

        public PodderzkaPolzovatey()
        {
            InitializeComponent();
          /*  connection.Open();
            var zayavka = "Select * From Abonent ";
            SqlCommand command = new SqlCommand(zayavka, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            this.dataGridView1.DataSource = data; */
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                buttonAbonent.Visible = false;
                buttonUprAborudov.Visible = false;
                buttonAktiv.Visible = false;
                buttonBilling.Visible = false;
                buttonPodderzka.Visible = false;
                buttonCRM.Visible = false;
                pictureBox1.Visible = false;
                panel1.BorderStyle = BorderStyle.None;

                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                buttonAbonent.Visible = true;
                buttonUprAborudov.Visible = true;
                buttonAktiv.Visible = true;
                buttonBilling.Visible = true;
                buttonPodderzka.Visible = true;
                buttonCRM.Visible = true;
                pictureBox1.Visible = true;
                panel1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        private void PodderzkaPolzovatey_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet1.Abonent". При необходимости она может быть перемещена или удалена.
         //   this.abonentTableAdapter.Fill(this.ws02DataSet1.Abonent);

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;

            label5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label11.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label13.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label14.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label15.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private  void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            var abonent = "Select * From Abonent Where ФИО = N'" + comboBox1.Text + "'";
            SqlCommand command = new SqlCommand(abonent, connection);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            SqlDataReader reader = command.ExecuteReader();
            this.dataGridView1.DataSource = data;
            if(reader.Read())
            {
               
                var mR = reader.GetValue(17); 
                reader.Close();
                var m = mR.ToString();
                var zayavka = "Select * From Zayavki Where Номер_заявки LIKE N'" + m + "%'";
                SqlCommand sqlCommand = new SqlCommand(zayavka, connection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                sqlData.Fill(dataTable);
                this.dataGridView1.DataSource = dataTable;
                
            }
            string t = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            if(t == "Видеонаблюдение")
            {

                dataGridView1.CurrentRow.Cells[7].Style.BackColor = Color.FromArgb(1960255);
            }
            */

           


        }

        private void buttonAbonent_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
            Hide();
        }

        private void buttonPodderzka_Click(object sender, EventArgs e)
        {
            PodderzkaPolzovatey podderzka = new PodderzkaPolzovatey();
            podderzka.Show();
            Hide();
        }

        private void buttonCRM_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            Hide();
        }

        private void buttonUprAborudov_Click(object sender, EventArgs e)
        {
            KontrolSostoania kontrol = new KontrolSostoania();
            kontrol.Show();
            Hide();
        }

        private void buttonBilling_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            Hide();
        }
    }
}
