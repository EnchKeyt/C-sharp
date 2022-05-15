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
    public partial class Abonent : Form
    {
       // SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws02;Persist Security Info=True;User ID=ws02;Password=2/G%raq№");

        public Abonent()
        {
            InitializeComponent();
         //   connection.Open();
        }

        private void Abonent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
          /*  this.sotrudnikTableAdapter.Fill(this.ws02DataSet.Sotrudnik);
            var kollekzia = "Select  Номер_абонента,ФИО,Номер_договора,Лицевой_счет,Услуги, Услуги1,Услуги2 From Abonent";
            SqlCommand command = new SqlCommand(kollekzia, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            sqlDataAdapter.Fill(dataTable);
            this.dataGVabonent.DataSource = dataTable; */


        }

        private void comboBoxPolzovateli_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  var kol = "Select * From Sotrudnik Where FIO = N'"+comboBoxPolzovateli.Text+"'";
            SqlCommand command = new SqlCommand(kol, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                var photoR = reader.GetValue(3);
                pictureBoxpolzovateli.Image = Image.FromFile("C:/Users/WorldSkills/source/repos/OOO Telecom Neva Svyaz ws02/Photo/"+ photoR + ".jpg");
                var dolznostR = reader.GetValue(2);
                var dolznost = dolznostR.ToString();
                Roli(dolznost);
            }
            reader.Close();
          */
        }
        //Раздача прав пользователям
        public void Roli(string dolznost)
        {
          /*  if(dolznost == "Руководитель отдела технической поддержки" )
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible= false;
                buttonBilling.Visible = true;
                buttonCRM.Visible = true;
                buttonPodderzka.Visible = false;
                buttonUprAborudov.Visible = false;
            }


            if (dolznost == "Специалист ТП (выездной инженер)")
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible = false;
                buttonBilling.Visible = false;
                buttonCRM.Visible = true;
                buttonPodderzka.Visible = true;
                buttonUprAborudov.Visible = true;
            }

            if (dolznost == "Директор по развитию")
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible = true;
                buttonBilling.Visible = true;
                buttonCRM.Visible = true;
                buttonPodderzka.Visible = true;
                buttonUprAborudov.Visible = true;
            }

            if (dolznost == "Технический департамент")
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible = true;
                buttonBilling.Visible = false;
                buttonCRM.Visible = true;
                buttonPodderzka.Visible = false;
                buttonUprAborudov.Visible = true;
            }

            if (dolznost == "Бухгалтер")
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible = true;
                buttonBilling.Visible = true;
                buttonCRM.Visible = false;
                buttonPodderzka.Visible = false;
                buttonUprAborudov.Visible = false;
            }



            if (dolznost == "Менеджер по работе с клиентами")
            {
                buttonAbonent.Visible = true;
                buttonAktiv.Visible = false;
                buttonBilling.Visible = false;
                buttonCRM.Visible = true;
                buttonPodderzka.Visible = false;
                buttonUprAborudov.Visible = false;
            }*/



        }

        private void buttonAbonent_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
            Hide();
        }

        private void radioButtonActiv_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void buttonCRM_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            /*if (checkBox1.Checked == true)
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
            if(checkBox1.Checked == false)
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
            */
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            KontrolSostoania kontrol = new KontrolSostoania();
            kontrol.Show();
            Hide();
        }

        private void buttonCRM_Click_1(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            Hide();
        }

        private void buttonPodderzka_Click(object sender, EventArgs e)
        {
            PodderzkaPolzovatey podderzka = new PodderzkaPolzovatey();
            podderzka.Show();
            Hide();
        }

        private void buttonAbonent_Click_1(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
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
