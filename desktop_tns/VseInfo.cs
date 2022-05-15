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
using System.Net;

namespace OOO_Telecom_Neva_Svyaz
{
    public partial class VseInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws02;Persist Security Info=True;User ID=ws02;Password=2/G%raq№");

        public VseInfo(string nomer)
        {
            InitializeComponent();
            connection.Open();
            var kollection = "Select * From Magistral Where Серийный_номер ='" + nomer + "'";
            SqlCommand command = new SqlCommand(kollection, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxSerNomer.Text = Convert.ToString(reader.GetValue(1));
                textBoxxarakteristika.Text = Convert.ToString(reader.GetValue(2));
    
              

            }
            reader.Close();

            var kol = "Select * From AbonentskoeOborudovanie Where Серийный_номер ='" + nomer + "'";
            SqlCommand com = new SqlCommand(kol, connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                textBoxSerNomer.Text = Convert.ToString(read.GetValue(1));
                textBoxxarakteristika.Text = Convert.ToString(read.GetValue(2));

                textBoxStandart.Text = Convert.ToString(read.GetValue(3));
                textBoxSkorost.Text = Convert.ToString(read.GetValue(4));
                textBoxIntrfeys.Text = Convert.ToString(read.GetValue(5));
                textBoxPort.Text = Convert.ToString(read.GetValue(6));

                textBoxIntrfeys.Visible = true;
                textBoxSkorost.Visible = true;
                textBoxPort.Visible = true;
                textBoxStandart.Visible = true;



            }
            read.Close();


            var koll = "Select * From SetiDostupa Where Серийный_номер ='" + nomer + "'";
            SqlCommand comm = new SqlCommand(koll, connection);
            SqlDataReader readerSql = comm.ExecuteReader();
            while (readerSql.Read())
            {
                textBoxSerNomer.Text = Convert.ToString(readerSql.GetValue(1));
                textBoxxarakteristika.Text = Convert.ToString(readerSql.GetValue(2));
                textBoxIntrfeys.Text = Convert.ToString(readerSql.GetValue(3));
                textBoxPort.Text = Convert.ToString(readerSql.GetValue(4));
                textBoxStandart.Text = Convert.ToString(readerSql.GetValue(5));
                textBoxChastota.Text = Convert.ToString(readerSql.GetValue(6));
                textBoxSkorost.Text = Convert.ToString(readerSql.GetValue(7));
                textBoxMesto.Text = Convert.ToString(readerSql.GetValue(8));

                textBoxIntrfeys.Visible = true;
                textBoxxarakteristika.Visible = true;
                textBoxPort.Visible = true;
                textBoxStandart.Visible = true;
                textBoxChastota.Visible = true;
                textBoxSkorost.Visible = true;
                textBoxMesto.Visible = true;
            }
            readerSql.Close();

        }

        private void VseInfo_Load(object sender, EventArgs e)
        {

        }

        private void buttonProverka_Click(object sender, EventArgs e)
        {
            var magist = new WebClient();


            var response = magist.DownloadString("http://itb.lrmk.ru:1000/api/equipment/state?serialNumber=" + textBoxSerNomer.Text);
           
            if (Convert.ToInt32(response) == 1)
            {
                MessageBox.Show("Оборудование работает");
            }
            if (Convert.ToInt32(response) == 0)
            {
                MessageBox.Show("Оборудование не работает");
            }

        }

     
    }
    
}
