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
    public partial class RedaktirovanMater : Form
    {
       // SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=wsdemo9;User ID=wsdemo9;Password=wsdemo9");
        public RedaktirovanMater()
        {
            InitializeComponent();
        }

        private void RedaktirovanMater_Load(object sender, EventArgs e)
        {
     //       connection.Open();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo9DataSet4.Материалы". При необходимости она может быть перемещена или удалена.
      //      this.материалыTableAdapter.Fill(this.wsdemo9DataSet4.Материалы);

        }

        private void Mater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //При выборе материала из таблицыи и клике на него(любое поле) данные выводятся в соответствующие поля
         /*   Kod.Text = Mater.CurrentRow.Cells[0].Value.ToString();
            naimen.Text = Mater.CurrentRow.Cells[1].Value.ToString();
            tip.Text = Mater.CurrentRow.Cells[2].Value.ToString();
            colich.Text = Mater.CurrentRow.Cells[5].Value.ToString();
            edIzm.Text = Mater.CurrentRow.Cells[8].Value.ToString();
            opis.Text = Mater.CurrentRow.Cells[9].Value.ToString();
            colVU.Text = Mater.CurrentRow.Cells[7].Value.ToString();
            stoim.Text = Mater.CurrentRow.Cells[4].Value.ToString();
            minCol.Text = Mater.CurrentRow.Cells[6].Value.ToString(); */
        }

        private void NaGlavn_Click(object sender, EventArgs e)
        {
            //Переход на главную страницу(Glavnaya)
            Glavnaya glavn = new Glavnaya();
            glavn.Show();
            Hide();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            //Переход на форму редактирования материалов(RedaktirovanMater)
            RedaktirovanMater redakt = new RedaktirovanMater();
            redakt.Show();
            Hide();
        }

        private void Red_Click(object sender, EventArgs e)
        {
            //Изменение данных о материалах в таблице
          /*  SqlCommand command = new SqlCommand("UPDATE[Материалы] SET Naimenovanie_materiala ='"+naimen.Text+ "', Tip_materiala ='" + tip.Text + "', Zena ='" + stoim.Text + "',Min_kolichestvo ='" + minCol.Text + "', Kolichestvo_v_upakovke ='" + colVU.Text + "', Opicanie ='" + opis.Text + "', Ediniza_izmerenia = '"+ edIzm.Text + "', Kolichestvo_na_sklade ='"+ colich.Text+ "' where Kod_materiala ='"+Kod.Text+"'", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Изменение сохранено"); */
        }

        private void delete_Click(object sender, EventArgs e)
        {
            //Удаление материалов из таблицы
          /*  SqlCommand command = new SqlCommand("DELETE FROM [Материалы] where Kod_materiala ='" + Kod.Text + "'", connection);
            command.ExecuteNonQuery();
            MessageBox.Show("Материал удален"); */
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
    }
}
