using Sessia_2.MClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessia_2
{
    public partial class MainForm : Form
    {
        MClass.Apps app;
        List<MClass.Users> allUsers;
        List<MClass.Abonts> allAbonts;
        public MainForm()
        {
            InitializeComponent();
            this.app = new MClass.Apps();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var res = this.app.db.Open();
            MessageBox.Show(res, "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

            minPanl.Visible = false;
            maxPanel.Visible = true;

            LTextP1.Text = "Абоненты";
            LTextP2.Text = "Управление\nоборудованием";
            LTextP3.Text = "Активы";
            LTextP4.Text = "Биллинг";
            LTextP5.Text = "Поддержка\nпользователей";
            LTextP6.Text = "CRM";

            mainLabel.Text = "Абоненты";

            checkMenu.Checked = true;

            allUsers = this.app.db.SelectUserSotrudnik();
            for (int i = 0; i < allUsers.Count; i++)
            {
                boxAllUser.Items.Add(allUsers[i].ФИО);
            }
            boxAllUser.SelectedIndex = 0;
            PUser( 0);

            AddGrid();
           

            DostupMod(allUsers[0].Должность);
        }

        private void AddGrid()
        {
            mainDataGrid.Rows.Clear();
            mainDataGrid.Columns.Clear();
            mainDataGrid.Columns.Add("Номер абонента", "Номер абонента");
            mainDataGrid.Columns.Add("ФИО", "ФИО");
            mainDataGrid.Columns.Add("Номер договора", "Номер договора");
            mainDataGrid.Columns.Add("Лицевой счет", "Лицевой счет");
            mainDataGrid.Columns.Add("Услуги", "Услуги");

            allAbonts = this.app.db.SelectAbonts();

            for (int i = 0; i < allAbonts.Count; i++)
            {
                mainDataGrid.Rows.Add();
                mainDataGrid.Rows[i].Cells[0].Value = allAbonts[i].Номер_абонента;
                mainDataGrid.Rows[i].Cells[1].Value = allAbonts[i].ФИО;
                mainDataGrid.Rows[i].Cells[2].Value = allAbonts[i].Номер_договора;
                mainDataGrid.Rows[i].Cells[3].Value = allAbonts[i].Лицевой_счет;
                mainDataGrid.Rows[i].Cells[4].Value = allAbonts[i].Услуги + ", " + allAbonts[i].Услуги1 + ", " +allAbonts[i].Услуги2;
            }
        }

        private void PUser(int v)
        {
            if (allUsers[v].Фото != null)
            {

                string img = allUsers[v].Фото + ".png";
                try
                {
                    PhotoUser.Image = Image.FromFile(@"..\..\img\imageUsers\" + img);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Конец списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    boxAllUser.SelectedIndex = allUsers.Count - 1;
                    img = allUsers[allUsers.Count - 1].Фото + ".png";
                    PhotoUser.Image = Image.FromFile(@"..\..\img\imageUsers\Фото для заглушки при отсутствии фото сотрудника.png");
                }
               
            }
        }

        private void DostupMod(string post)
        {
            pict1.Visible = false; // Абоненты 
            pict2.Visible = false; // Управление оборудованием
            pict3.Visible = false; // Активы
            pict4.Visible = false; // Биллинг
            pict5.Visible = false; // Поддержка пользователей
            pict6.Visible = false; // CRM

            mpict1.Visible = false;
            mpict2.Visible = false;
            mpict3.Visible = false;
            mpict4.Visible = false;
            mpict5.Visible = false;
            mpict6.Visible = false;

            LTextP1.Visible = false;
            LTextP2.Visible = false;
            LTextP3.Visible = false;
            LTextP4.Visible = false;
            LTextP5.Visible = false;
            LTextP6.Visible = false;

            if (post == "Руководитель по работе с клиентами")
            {
                pict1.Visible = true; // Абоненты
                LTextP1.Visible = true;
                mpict1.Visible = true;


                pict6.Visible = true; // CRM
                LTextP6.Visible = true;
                mpict6.Visible = true;


                pict4.Visible = true; // Биллинг
                LTextP4.Visible = true;
                mpict4.Visible = true;

            }
            else if(post == "Менеджер по работе с клиентами")
            {
                pict1.Visible = true; // Абоненты
                LTextP1.Visible = true;
                mpict1.Visible = true;


                pict6.Visible = true; // CRM
                LTextP6.Visible = true;
                mpict6.Visible = true;


            }
            else if(post == "Руководитель отдела технической поддержки")
            {
                pict1.Visible = true; // Абоненты
                LTextP1.Visible = true;
                mpict1.Visible = true;


                pict2.Visible = true; // Управление оборудованием
                LTextP2.Visible = true;
                mpict2.Visible = true;



                pict5.Visible = true; // Поддержка пользователей
                LTextP5.Visible = true;
                mpict5.Visible = true;

                pict6.Visible = true; // CRM
                LTextP6.Visible = true;
                mpict6.Visible = true;

            }
            else if(post == "Специалист ТП (выездной инженер)")
            {
                pict1.Visible = true; // Абоненты
                LTextP1.Visible = true;
                mpict1.Visible = true;

                pict2.Visible = true; // Управление оборудованием
                LTextP2.Visible = true;
                mpict2.Visible = true;


                pict5.Visible = true; // Поддержка пользователей
                LTextP5.Visible = true;
                mpict5.Visible = true;

                pict6.Visible = true; // CRM
                LTextP6.Visible = true;
                mpict6.Visible = true;

            }
            else if(post == "Бухгалтер")
            {
                pict1.Visible = true; // Абоненты
                LTextP1.Visible = true;
                mpict1.Visible = true;

                pict3.Visible = true; // Активы
                LTextP3.Visible = true;
                mpict3.Visible = true;

                pict4.Visible = true; // Биллинг
                LTextP4.Visible = true;
                mpict4.Visible = true;

            }
            else if(post == "Директор по развитию")
            {
                pict1.Visible = true; // Абоненты
                pict2.Visible = true; // Управление оборудованием
                pict3.Visible = true; // Активы
                pict4.Visible = true; // Биллинг
                pict5.Visible = true; // Поддержка пользователей
                pict6.Visible = true; // CRM.
                LTextP1.Visible = true;
                LTextP2.Visible = true;
                LTextP3.Visible = true;
                LTextP4.Visible = true;
                LTextP5.Visible = true;
                LTextP6.Visible = true;

                mpict1.Visible = true;
                mpict2.Visible = true;
                mpict3.Visible = true;
                mpict4.Visible = true;
                mpict5.Visible = true;
                mpict6.Visible = true;

            }
            else if(post == "Технический департамент")
            {
                pict1.Visible = true; // Абоненты
                pict2.Visible = true; // Управление оборудованием
                pict3.Visible = true; // Активы
                pict6.Visible = true; // CRM
                LTextP1.Visible = true;
                LTextP2.Visible = true;
                LTextP3.Visible = true;
                LTextP6.Visible = true;
                
            }

        }

        private void minPanl_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void minPanl_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkMenu.Checked)
            {
                minPanl.Visible = true;
                maxPanel.Visible = false;
            }
            else
            {
                minPanl.Visible = false;
                maxPanel.Visible = true;
            }
        }

        private void boxAllUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            PUser(boxAllUser.SelectedIndex);
            DostupMod(allUsers[boxAllUser.SelectedIndex].Должность);
        }

        private void mainDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AllOneUser oneUser = new AllOneUser(allAbonts[e.RowIndex]);
            oneUser.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var res = this.app.db.Close();
            MessageBox.Show(res, "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pict6_Click(object sender, EventArgs e)
        {
            CRM crm = new CRM(this.app);
            crm.Show();
        }


        private void TFind_TextChanged(object sender, EventArgs e)
        {
            List<Abonts> abonetns = new List<Abonts>();
            if (BoxFind.SelectedIndex == 0) // По фамилии
            {
                for (int i = 0; i < allAbonts.Count; i++)
                {
                    if (allAbonts[i].ФИО.Contains(TFind.Text))
                    {
                        abonetns.Add(allAbonts[i]);
                    }
                }    
            }
            else if(BoxFind.SelectedIndex == 1) //По району
            {
                for (int i = 0; i < allAbonts.Count; i++)
                {
                    if (allAbonts[i].Адрес_проживания.Contains(TFind.Text))
                    {
                        abonetns.Add(allAbonts[i]);
                    }
                }
            }
            else if (BoxFind.SelectedIndex == 2) // По улице
            {
                for (int i = 0; i < allAbonts.Count; i++)
                {
                    if (allAbonts[i].Адрес_проживания.Contains(TFind.Text))
                    {
                        abonetns.Add(allAbonts[i]);
                    }
                }
            }
            else if (BoxFind.SelectedIndex == 3) // По лицевому счету
            {
                for (int i = 0; i < allAbonts.Count; i++)
                {
                    if (allAbonts[i].Лицевой_счет.Contains(TFind.Text))
                    {
                        abonetns.Add(allAbonts[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < allAbonts.Count; i++)
                {

                    abonetns.Add(allAbonts[i]);
                }
            }
            AddGrid(abonetns);



        }

        private void AddGrid(List<Abonts> abonts)
        {
            mainDataGrid.Rows.Clear();
            mainDataGrid.Columns.Clear();
            mainDataGrid.Columns.Add("Номер абонента", "Номер абонента");
            mainDataGrid.Columns.Add("ФИО", "ФИО");
            mainDataGrid.Columns.Add("Номер договора", "Номер договора");
            mainDataGrid.Columns.Add("Лицевой счет", "Лицевой счет");
            mainDataGrid.Columns.Add("Услуги", "Услуги");

            allAbonts = this.app.db.SelectAbonts();

            for (int i = 0; i < abonts.Count; i++)
            {
                mainDataGrid.Rows.Add();
                mainDataGrid.Rows[i].Cells[0].Value = abonts[i].Номер_абонента;
                mainDataGrid.Rows[i].Cells[1].Value = abonts[i].ФИО;
                mainDataGrid.Rows[i].Cells[2].Value = abonts[i].Номер_договора;
                mainDataGrid.Rows[i].Cells[3].Value = abonts[i].Лицевой_счет;
                mainDataGrid.Rows[i].Cells[4].Value = abonts[i].Услуги + ", " + abonts[i].Услуги1 + ", " + abonts[i].Услуги2;
            }
        }
    }
}
