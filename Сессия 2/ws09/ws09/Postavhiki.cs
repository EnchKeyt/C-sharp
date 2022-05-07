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

namespace ws09
{
    public partial class Postavhiki : Form
    {
     //   SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=wsdemo9;User ID=wsdemo9;Password=wsdemo9");

        public Postavhiki()
        {
            InitializeComponent();
        }

        private void Postavhiki_Load(object sender, EventArgs e)
        {
           // connection.Open();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo9DataSet5.Поставщики". При необходимости она может быть перемещена или удалена.
         //   this.поставщикиTableAdapter.Fill(this.wsdemo9DataSet5.Поставщики);

        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            
        }

        private void NaGlavn_Click(object sender, EventArgs e)
        {
            //Переход на главную страницу(Glavnaya)
            Glavnaya glavn = new Glavnaya();
            glavn.Show();
            Hide();
        }

        private void Sev_Click(object sender, EventArgs e)
        {
            //Сохранение новых материалов базу данных Материалы
          /*  SqlCommand command = new SqlCommand("INSERT INTO [Поставщики](Naimenovanie_postavhika,Tip_postavhika, INN,Reyting_kahestva,Data_nahala_raboti_s_postavhikom) VALUES ('" + naimen.Text + "','" + tip.Text + "','" + inn.Text + "','" + reyt.Text + "','" + dat.CustomFormat + "')", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Сохранение выполнено"); */
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Отчистка полей данных
            naimen.Text = "";
            tip.Text = "";
            inn.Text = "";
            reyt.Text = "";
            MessageBox.Show("Поля отчищены");
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //При выборе материала из таблицыи клике на него(любое поле) данные выводятся в соответствующие поля
           /* naimen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tip.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            inn.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            reyt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); */
            
        }
    }
}
