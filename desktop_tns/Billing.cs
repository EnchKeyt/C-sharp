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
    public partial class Billing : Form
    {
       // SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws02;Persist Security Info=True;User ID=ws02;Password=2/G%raq№");
        public Billing()
        {
            InitializeComponent();
           /* connection.Open();
            var koll = "Select * From PlateziAbonrov ";
            SqlCommand command = new SqlCommand(koll, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);

            this.dataGridView1.DataSource = dataTable; */

        }

        private void buttonAbonent_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

          /*  if (checkBox1.Checked == true)
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
            } */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet4.PlateziAbonrov". При необходимости она может быть перемещена или удалена.
            //this.plateziAbonrovTableAdapter.Fill(this.ws02DataSet4.PlateziAbonrov);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       

          /*  var koll = "Select * From Tarif Where Услуга = '" + comboBox1.Text + "'";
            SqlCommand command = new SqlCommand(koll, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);

            this.dataGridView1.DataSource = dataTable; */
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          /*  var koll = "Select * From PlateziAbonrov Where Задолженность != '"+null+"'";
            SqlCommand command = new SqlCommand(koll, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);

            this.dataGridView1.DataSource = dataTable; */
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           /* var koll = "Select * From PlateziAbonrov ";
            SqlCommand command = new SqlCommand(koll, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);

            this.dataGridView1.DataSource = dataTable; */
        }
    }
}
