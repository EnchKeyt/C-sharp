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

namespace Autorization
{
    public partial class Autorization : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=WORLDSKILLS-ITB\SQLEXPRESS;Initial Catalog=ws06;Persist Security Info=True;User ID=ws06;Password=6msFD%].");
        string text = "";
        public Autorization()
        {
            InitializeComponent();
            connection.Open();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
            PicLogo.Image = new Bitmap(@"../../img/Лого ТНС.jpg");
            PicUpdate.Image = new Bitmap(@"../../img/На авторизацию_Обновление кода.jpg");
        }
        void generate()
        {
            Random rnd = new Random();  //Генератор символов
            text = "";
            string ALF = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗФЫВАПРОЛДЖЭЯЧСМИТЬБЮ1234567890!@?%&";
            for (int i = 0; i < 8; i++)
            {
                text += ALF[rnd.Next(ALF.Length)];
            }
            MessageBox.Show("Ваш код " + text);
        }
        private void Login_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE Number = '"+ TxtNumber.Text +"' AND Password = '"+ TxtPass.Text +"'", connection);
            data.SelectCommand = command;
            data.Fill(table);
            if (table.Rows.Count > 0 && text == TxtCode.Text && TxtCode.Text != "" )
            {
               
                switch (TxtNumber.Text)
                {
                    case "1":
                        MessageBox.Show("Ваша роль: Руководитель отдела по работе с клиентами");
                        break;
                    case "2":
                        MessageBox.Show("Ваша роль: Менеджер по работе с клиентами");
                        break;
                    case "3":
                        MessageBox.Show("Ваша роль: Руководитель отдела технической поддержки");
                        break;
                    case "4":
                        MessageBox.Show("Ваша роль: Специалист технической поддержки");
                        break;
                    case "5":
                        MessageBox.Show("Ваша роль: Бухгалтер");
                        break;
                    case "6":
                        MessageBox.Show("Ваша роль: Директор по развитию");
                        break;
                    case "7":
                        MessageBox.Show("Ваша роль: Сотрудник технического департамента");
                        break;
                }
            }
            else
            {
                generate();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            TxtCode.Text = "";
            TxtNumber.Text = "";
            TxtPass.Text = "";
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                SqlDataAdapter data = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE Password = '" + TxtPass.Text + "'", connection);
                data.SelectCommand = command;
                data.Fill(table);
                if (table.Rows.Count > 0)
                {
                    TxtPass.ReadOnly = false;
                    TxtCode.ReadOnly = false;
                    generate();
                }
                else
                {
                    MessageBox.Show("Пароль неверный!");
                }

            }
        }

        private void PicUpdate_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void TxtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SqlDataAdapter data = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE Number = '" + TxtNumber.Text + "'", connection);
                data.SelectCommand = command;
                data.Fill(table);
                if (table.Rows.Count > 0)
                {
                    TxtPass.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Данного номера не существует в базе!");
                }
            }
        }
    }
        }

