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
    public partial class FormUVP : Form
    {
        public FormUVP()
        {
            InitializeComponent();
        }

        private void pictureBoxModUVP_Click(object sender, EventArgs e)
        {

        }

        private void FormUVP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSet.SotrudniksTNC". При необходимости она может быть перемещена или удалена.
            this.sotrudniksTNCTableAdapter.Fill(this.ws04DataSet.SotrudniksTNC);

        }

        private void buttonTVSB_Click(object sender, EventArgs e)
        {
            new FormInterfaceNVP().Show();
        }

        private void buttonTVCHT_Click(object sender, EventArgs e)
        {
            new FormInterfaceNVP().Show();
        }

        private void buttonNCHT_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime11_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime12_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime13_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime14_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime15_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonTime16_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }
    }
}
