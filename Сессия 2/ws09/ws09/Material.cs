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
    public partial class Material : Form
    {
      //  SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=wsdemo9;User ID=wsdemo9;Password=wsdemo9");
        public Material()
        {
            InitializeComponent();
        }

        private void Material_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wsdemo9DataSet4.Материалы". При необходимости она может быть перемещена или удалена.
            //this.материалыTableAdapter2.Fill(this.wsdemo9DataSet4.Материалы);
            
       //     connection.Open();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Переход на форму добавления материалов(MaterialDobav)
            MaterialDobav dobav = new MaterialDobav();
            dobav.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Переход на главную страницу(Glavnaya)
            Glavnaya glavn = new Glavnaya();
            glavn.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Переход на форму редактирования материалов(RedaktirovanMater)
            RedaktirovanMater redakt = new RedaktirovanMater();
            redakt.Show();
            Hide();
        }
    }
}
