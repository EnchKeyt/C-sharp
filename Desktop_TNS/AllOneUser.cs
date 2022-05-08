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
    public partial class AllOneUser : Form
    {
        public AllOneUser(MClass.Abonts abonts)
        {
            InitializeComponent();
            OneAdbonts.Columns.Add("Номер_абонента", "Номер_абонента");
            OneAdbonts.Columns.Add("ФИО", "ФИО");
            OneAdbonts.Columns.Add("Пол", "Пол");
            OneAdbonts.Columns.Add("Дата_рождения", "Дата_рождения");
            OneAdbonts.Columns.Add("Номер_телефона", "Номер_телефона");
            OneAdbonts.Columns.Add("Электронная_почта", "Электронная_почта");
            OneAdbonts.Columns.Add("Адрес_прописки", "Адрес_прописки");
            OneAdbonts.Columns.Add("Адрес_проживания", "Адрес_проживания");
            OneAdbonts.Columns.Add("Серия_и_номер_паспорта", "Серия_и_номер_паспорта");
            OneAdbonts.Columns.Add("Код_подразделения", "Код_подразделения");
            OneAdbonts.Columns.Add("Кем_выдан", "Кем_выдан");
            OneAdbonts.Columns.Add("Дата_выдачи_паспорта", "Дата_выдачи_паспорта");
            OneAdbonts.Columns.Add("Номер_договора", "Номер_договора");
            OneAdbonts.Columns.Add("Дата_заключения_договора", "Дата_заключения_договора");
            OneAdbonts.Columns.Add("Тип_договора", "Тип_договора");
            OneAdbonts.Columns.Add("Причина_расторжения_договора", "Причина_расторжения_договора");
            OneAdbonts.Columns.Add("Лицевой_счет", "Лицевой_счет");
            OneAdbonts.Columns.Add("Услуги", "Услуги");
            OneAdbonts.Columns.Add("Услуги1", "Услуги1");
            OneAdbonts.Columns.Add("Услуги2", "Услуги2");
            OneAdbonts.Columns.Add("Дата_расторжения_договора", "Дата_расторжения_договора");
            OneAdbonts.Columns.Add("F22", "F22");
            OneAdbonts.Columns.Add("Серийный_номер_оборудования", "Серийный_номер_оборудования");

            OneAdbonts.Rows.Add();
            OneAdbonts.Rows[0].Cells[0].Value = abonts.Номер_абонента;
            OneAdbonts.Rows[0].Cells[1].Value = abonts.ФИО;
            OneAdbonts.Rows[0].Cells[2].Value = abonts.Пол;
            OneAdbonts.Rows[0].Cells[3].Value = abonts.Дата_рождения;
            OneAdbonts.Rows[0].Cells[4].Value = abonts.Номер_телефона;
            OneAdbonts.Rows[0].Cells[5].Value = abonts.Электронная_почта;
            OneAdbonts.Rows[0].Cells[6].Value = abonts.Адрес_прописки;
            OneAdbonts.Rows[0].Cells[7].Value = abonts.Адрес_проживания;
            OneAdbonts.Rows[0].Cells[8].Value = abonts.Серия_и_номер_паспорта;
            OneAdbonts.Rows[0].Cells[9].Value = abonts.Код_подразделения;
            OneAdbonts.Rows[0].Cells[10].Value = abonts.Кем_выдан;
            OneAdbonts.Rows[0].Cells[11].Value = abonts.Дата_выдачи_паспорта;
            OneAdbonts.Rows[0].Cells[12].Value = abonts.Номер_договора;
            OneAdbonts.Rows[0].Cells[13].Value = abonts.Дата_заключения_договора;
            OneAdbonts.Rows[0].Cells[14].Value = abonts.Тип_договора;
            OneAdbonts.Rows[0].Cells[15].Value = abonts.Причина_расторжения_договора;
            OneAdbonts.Rows[0].Cells[16].Value = abonts.Лицевой_счет;
            OneAdbonts.Rows[0].Cells[17].Value = abonts.Услуги;
            OneAdbonts.Rows[0].Cells[18].Value = abonts.Услуги1;
            OneAdbonts.Rows[0].Cells[19].Value = abonts.Услуги2;
            OneAdbonts.Rows[0].Cells[20].Value = abonts.Дата_расторжения_договора;
            OneAdbonts.Rows[0].Cells[21].Value = abonts.Серийный_номер_оборудования;
    }

        private void AllOneUser_Load(object sender, EventArgs e)
        {

        }
    }
}
