using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Telecom_Neva_Svyaz
{
    
    public partial class KontrolSostoania : Form
    {
       // public string repos { get; set; }
        public KontrolSostoania()
        {
            InitializeComponent();
        }

        private void KontrolSostoania_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet2.AbonentskoeOborudovanie". При необходимости она может быть перемещена или удалена.
           // this.abonentskoeOborudovanieTableAdapter.Fill(this.ws02DataSet2.AbonentskoeOborudovanie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet2.SetiDostupa". При необходимости она может быть перемещена или удалена.
          //  this.setiDostupaTableAdapter.Fill(this.ws02DataSet2.SetiDostupa);
           // TODO: данная строка кода позволяет загрузить данные в таблицу "ws02DataSet2.Magistral". При необходимости она может быть перемещена или удалена.
        //    this.magistralTableAdapter.Fill(this.ws02DataSet2.Magistral);

        }


        private void dataGVMagistSeti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Проверка работы оборудование через  API
         /*   var nomer = dataGVMagistSeti.CurrentRow.Cells[1].Value.ToString();
            var magist = new WebClient();

            
            var response = magist.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + nomer);

                if (Convert.ToInt32(response) == 1)
                {
                    
                    dataGVMagistSeti.CurrentRow.Cells[1].Style.BackColor = Color.White;

                }
                if (Convert.ToInt32(response) == 0)
                {
                    
                    dataGVMagistSeti.CurrentRow.Cells[1].Style.BackColor = Color.Red;

                } */
      

           
        }

        private void dataGVSetiDosupa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Проверка работы оборудование через  API
          /*  var nomer = dataGVSetiDosupa.CurrentRow.Cells[1].Value.ToString();
            var magist = new WebClient();


            var response = magist.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + nomer);

            if (Convert.ToInt32(response) == 1)
            {
       
                dataGVSetiDosupa.CurrentRow.Cells[1].Style.BackColor = Color.White;

            }
            if (Convert.ToInt32(response) == 0)
            {
   
                dataGVSetiDosupa.CurrentRow.Cells[1].Style.BackColor = Color.Red;

            } */

        }

       private void dataGVOborudObonenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Проверка работы оборудование через  API
           /* var nomer = dataGVOborudObonenta.CurrentRow.Cells[1].Value.ToString();
            var magist = new WebClient();


            var response = magist.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + nomer);

            if (Convert.ToInt32(response) == 1)
            {
     
                dataGVOborudObonenta.CurrentRow.Cells[1].Style.BackColor = Color.White;

            }
            if (Convert.ToInt32(response) == 0)
            {
         
                dataGVOborudObonenta.CurrentRow.Cells[1].Style.BackColor = Color.Red;

            } */
        }

        private void dataGVMagistSeti_DoubleClick(object sender, EventArgs e)
        {
           /* string nomer = dataGVMagistSeti.CurrentRow.Cells[1].Value.ToString();
            VseInfo info = new VseInfo(nomer);

            info.Show(); */
        }

        private void dataGVSetiDosupa_DoubleClick(object sender, EventArgs e)
        {
          /*  string nomer = dataGVSetiDosupa.CurrentRow.Cells[1].Value.ToString();
            VseInfo info = new VseInfo(nomer);
            info.Show(); */
        }

        private void dataGVOborudObonenta_DoubleClick(object sender, EventArgs e)
        {
          /*  string nomer = dataGVOborudObonenta.CurrentRow.Cells[1].Value.ToString();
            VseInfo info = new VseInfo(nomer);
            info.Show(); */
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

        private void buttonCRM_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CRM cRM = new CRM();
            cRM.Show();
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

        private void labelKontrol_Click(object sender, EventArgs e)
        {

        }
    }
}
