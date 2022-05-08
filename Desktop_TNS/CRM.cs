using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Sessia_2
{
    public partial class CRM : Form
    {
        MClass.Apps app;
        public CRM(MClass.Apps app)
        {
            InitializeComponent();
            this.app = app;
            TestProgress.Visible = false;
        }

        private void TNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var time = new DateTime();
                
                var allabont = this.app.db.SelectAbonts();
                for (int i = 0; i < allabont.Count; i++)
                {
                    if (allabont[i].ФИО.Contains(TFio.Text))
                    {
                        TFio.Text = allabont[i].ФИО;
                        TNumberPhone.Text = allabont[i].Номер_телефона;
                        var res = MessageBox.Show($"Обнаружен пользователь: {allabont[i].ФИО} добавить?", "Ответ базы данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (DialogResult.Yes == res)
                        {
                            TNumber.Text = allabont[i].Лицевой_счет + "/15/02/2022";
                            TDate.Text = "15.02.2022";
                            TNumberID.Text = allabont[i].Номер_абонента;
                            TCount.Text = allabont[i].Лицевой_счет;
                            TTypeOborud.Text = allabont[i].Серийный_номер_оборудования;
                        }
                    }
                }

            }
        }

        private void CRM_Load(object sender, EventArgs e)
        {
           
            BoxStatus.SelectedIndex = 0;
            TNumber.Text = "0";

            TNumber.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestProgress.Visible = true;
            string url = "http://itb.lrmk.ru:1000/api/equipment/state";
            using (var webClient = new WebClient()){


                var response = webClient.DownloadString(url + "?serialNumber=" + TTypeOborud.Text);

                TestProgress.Value = 100;

                if (response == "1")
                {
                    MessageBox.Show("Оборудование исправно", "Тестирование оборудования", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BoxStatus.SelectedIndex = 2;
                    BoxStatus.Enabled = false;
                    TDateClose.Text = "15.02.2022";
                }
                else if (response == "0")
                {
                    MessageBox.Show("Оборудование не исправно", "Тестирование оборудования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BoxStatus.SelectedIndex = 1;
                    BoxStatus.Enabled = false;
                }
                TestProgress.Value = 0;


            }
        }


    }
}
