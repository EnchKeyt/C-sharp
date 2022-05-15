using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        static DataRow authorizationDataRow;

        public void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (NumberTextBox.Text == "")
                {
                    MessageBox.Show("Вы не ввели номер!");
                    return;
                }

                try
                {
                    Convert.ToInt32(NumberTextBox.Text);
                }

                catch
                {
                    MessageBox.Show("Вводите только цифры!");
                    return;
                }

                MySqlDataAdapter authorizationAdapter;
                DataSet authorizationDataSet = new DataSet();
                DataTable authorizationDataTable = new DataTable();

                string connectionString = @"server=192.168.101.1;userid=ws01;password=1rNkX'%5;database=ws01;charset=utf8mb4;";
                string sql = "SELECT * FROM users WHERE number = " + NumberTextBox.Text;

                MySqlConnection connection = new MySqlConnection(connectionString);
                authorizationAdapter = new MySqlDataAdapter(sql, connection);
                authorizationAdapter.Fill(authorizationDataSet, "users");
                authorizationDataTable = authorizationDataSet.Tables["users"];

                try
                {
                    connection.Open();

                    MessageBox.Show("Успешное подключение к базе данных!");

                    connection.Close();
                }
                catch
                {
                    MessageBox.Show("При подключении к базе данных возникла ошибка!");
                }

                try
                {
                    authorizationDataRow = authorizationDataTable.Rows[0];

                    PasswordTextBox.Enabled = true;
                }

                catch
                {
                    MessageBox.Show("Не верный номер!");
                }
            }
        }

        public void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13) { 
                if (PasswordTextBox.Text == "")
                {
                    MessageBox.Show("Вы не ввели пароль!");
                    return;
                }

                if (authorizationDataRow.Field<string>("password") == PasswordTextBox.Text)
                {
                    MessageBox.Show("Пароль правильный!");
                }
                else
                {
                    MessageBox.Show("Не верный пароль!");
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NumberTextBox.Text = "";
            PasswordTextBox.Text = "";
            CodeTextBox.Text = "";

            PasswordTextBox.Enabled = false;
        }
    }
}