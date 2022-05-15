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
    public partial class FormUSO : Form
    {
        public FormUSO()
        {
            InitializeComponent();
        }
        private void FormUSO_Load(object sender, EventArgs e)
        {
            
        }

        private void ToolStripMenuItemKS_Click(object sender, EventArgs e)
        {
            FormKS formKS = new FormKS();
            formKS.MdiParent = this;
            formKS.Show();
        }

        private void ToolStripMenuItemNO_Click(object sender, EventArgs e)
        {
            SorryDeveloping();

        }

        private void ToolStripMenuItemRKBS_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }
        ///Фича разраба. Зажми на menuStripMain кнопку ToolStripMenuItemNO или ToolStripMenuItemRKBS и проведи вниз, чтобы просмотреть версию в разработке
        private void DevToolStripMenuItemRKBS_Click(object sender, EventArgs e)
        {
            FormRKBS formRKBS = new FormRKBS();
            formRKBS.MdiParent = this;
            formRKBS.Show();
        }

        private void DevToolStripMenuItemNO_Click(object sender, EventArgs e)
        {
            FormNO formNO = new FormNO();
            formNO.MdiParent = this;
            formNO.Show();
        }
    }
}
