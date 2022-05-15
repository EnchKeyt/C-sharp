using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormsModuleCRM.SorryDev;

namespace FormsModuleCRM
{
    public partial class FormWorkWithAbonents : Form
    {
        public FormWorkWithAbonents()
        {
            InitializeComponent();
        }

        private void FormWorkWithAbonents_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSet.Abonents". При необходимости она может быть перемещена или удалена.
        //    this.abonentsTableAdapter.Fill(this.ws04DataSet.Abonents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSet.SotrudniksTNC". При необходимости она может быть перемещена или удалена.
        //    this.sotrudniksTNCTableAdapter.Fill(this.ws04DataSet.SotrudniksTNC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSet.InfoForSotrudniks". При необходимости она может быть перемещена или удалена.
          //  this.infoForSotrudniksTableAdapter.Fill(this.ws04DataSet.InfoForSotrudniks);

            //pictureBox1.Image = comboBox1.ValueMember;
        }

        private void pictureBoxModUSO_Click(object sender, EventArgs e)
        {
            new FormUSO().Show();
        }

        private void buttonSob_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void pictureBoxModUVP_Click(object sender, EventArgs e)
        {
            new FormUVP().Show();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }
    }    
}