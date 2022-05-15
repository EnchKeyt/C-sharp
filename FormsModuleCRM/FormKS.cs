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
    public partial class FormKS : Form
    {
        public FormKS()
        {
            InitializeComponent();
        }

        private void FormKS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSetKS.SetiDostupa". При необходимости она может быть перемещена или удалена.
       //     this.setiDostupaTableAdapter.Fill(this.ws04DataSetKS.SetiDostupa);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSetKS.Magistral". При необходимости она может быть перемещена или удалена.
         //   this.magistralTableAdapter.Fill(this.ws04DataSetKS.Magistral);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ws04DataSetKS.AbonentskoeOborudovanie". При необходимости она может быть перемещена или удалена.
         //   this.abonentskoeOborudovanieTableAdapter.Fill(this.ws04DataSetKS.AbonentskoeOborudovanie);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SorryDeveloping();
        }
    }
}
