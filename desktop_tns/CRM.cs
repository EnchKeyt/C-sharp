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
using System.Net.Http;
using System.Net;

namespace OOO_Telecom_Neva_Svyaz
{

    public partial class CRM : Form
    {   
        //SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws02;Persist Security Info=True;User ID=ws02;Password=2/G%raq№");

        public CRM()
        {
        //    connection.Open();
            InitializeComponent();
        }

        private void CRM_Load(object sender, EventArgs e)
        {

        }

        private void buttonProverka_Click(object sender, EventArgs e)
        {

            /*   var kollection = "Select * From Abonent Where Номер_телефона ='" + textBoxNomerTel.Text + "' AND ФИО = '" + textBoxFamil.Text + "'";
               SqlCommand com = new SqlCommand(kollection, connection);
               DataTable data = new DataTable();
               SqlDataAdapter adapter = new SqlDataAdapter(com);


               adapter.Fill(data);

              */
            if (textBoxNomerTel.Text == "1" && textBoxFamil.Text =="1") //com.ExecuteScalar() != null)
            {
                MessageBox.Show("Абонент найден");

                labelNomerTel.Visible = false;
                labelFamil.Visible = false;
                textBoxFamil.Visible = false;
                textBoxNomerTel.Visible = false;
                buttonProverka.Visible = false;

                textBoxDateZayvki.Visible = true;
                textBoxLS.Visible = true;
                textBoxNomerzayavki.Visible = true;
                textBoxOpisproblem.Visible = true;
                textBoxTipOborud.Visible = true;
                textBoxTipUslugi.Visible = true;
                textBoxUsluga.Visible = true;
                textBoxVidUslugi.Visible = true;
                textBoxNomerAbonent.Visible = true;
                comboBoxStatus.Visible = true;
                comboBoxTipProbem.Visible = true;
                DateZacritia.Visible = true;
                label1.Visible = true;
                label2.Visible = true;

                textBoxOborud.Visible = true;
                buttonProverkaObo.Visible = true;
            }              
            /* SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    textBoxOborud.Text = Convert.ToString(reader.GetValue(23));
                    string ls = Convert.ToString(reader.GetValue(17));
                    textBoxNomerzayavki.Text = ls + "/" + Convert.ToString(DateTime.Now);
                }
                reader.Close();
         
               

            }*/

            else
            {
                MessageBox.Show("Абонент не найден");
            }
        }

  
        private void buttonAbonent_Click(object sender, EventArgs e)
        {
            Abonent abonent = new Abonent();
            abonent.Show();
            Hide();
        }

        private void buttonCRM_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            Hide();
        }

        private void buttonProverkaObo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ob = random.Next(0,2);

           /* WebClient httpClient = new WebClient();
            var ob = httpClient.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + textBoxOborud.Text); */
            if (ob == 1)
            {
                comboBoxStatus.Text = "Закрыта";
                MessageBox.Show("Оборудование работает");
            }
            if (ob == 0)
            {
                comboBoxStatus.Text = "Требует выезда";
                MessageBox.Show("Оборудование не работает");
            } 
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
    }
           

       
    
}
