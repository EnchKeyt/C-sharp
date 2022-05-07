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
    public partial class MaterialDobav : Form
    {
     //   SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=wsdemo9;User ID=wsdemo9;Password=wsdemo9");
        public MaterialDobav()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo9DataSet7.Материалы". При необходимости она может быть перемещена или удалена.
           // this.материалыTableAdapter5.Fill(this.wsdemo9DataSet7.Материалы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo9DataSet6.Материал". При необходимости она может быть перемещена или удалена.
          //  this.материалTableAdapter.Fill(this.wsdemo9DataSet6.Материал);
       



       //     connection.Open();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранение новых материалов базу данных Материалы
         /*   SqlCommand command = new SqlCommand("INSERT INTO [Материалы](Naimenovanie_materiala,Tip_materiala,Kolichestvo_na_sklade,Ediniza_izmerenia,Opicanie,Kolichestvo_v_upakovke,Zena, Min_kolichestvo) VALUES ('" + naimen.Text+"','"+tip.Text+"','"+colich.Text+"','"+ edIzm .Text+ "','"+ opis .Text+ "','"+colVU.Text+"','"+ stoim .Text+ "','"+ minCol .Text+ "')", connection);
            command.ExecuteNonQuery();*/
            MessageBox.Show("Сохранение выполнено"); 
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            //Переход на одну форму(Material) назад
            Material mater = new Material();
            mater.Show();
            Hide(); 
        }

        private void NaGlavn_Click(object sender, EventArgs e)
        {
            //Переход на главную страницу(Glavnaya)
            Glavnaya glavn = new Glavnaya();
            glavn.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //Отчистка полей данных
            naimen.Text = "";
            tip.Text = "";
            colich.Text = "";
            edIzm.Text = "";
            opis.Text = "";
            colVU.Text = "";
            stoim.Text = "";
            minCol.Text = "";
            MessageBox.Show("Поля отчищены");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
