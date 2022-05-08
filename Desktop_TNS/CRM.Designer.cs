
namespace Sessia_2
{
    partial class CRM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRM));
            this.LNumber = new System.Windows.Forms.Label();
            this.TNumber = new System.Windows.Forms.TextBox();
            this.LDate = new System.Windows.Forms.Label();
            this.TDate = new System.Windows.Forms.TextBox();
            this.LNumberID = new System.Windows.Forms.Label();
            this.TNumberID = new System.Windows.Forms.TextBox();
            this.LCount = new System.Windows.Forms.Label();
            this.TCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxUslug = new System.Windows.Forms.ComboBox();
            this.LType = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.BoxStatus = new System.Windows.Forms.ComboBox();
            this.LTypeOborud = new System.Windows.Forms.Label();
            this.TTypeOborud = new System.Windows.Forms.TextBox();
            this.LTypeProbl = new System.Windows.Forms.Label();
            this.TTypeProbl = new System.Windows.Forms.TextBox();
            this.LProbl = new System.Windows.Forms.Label();
            this.TProbl = new System.Windows.Forms.TextBox();
            this.LDateClose = new System.Windows.Forms.Label();
            this.TDateClose = new System.Windows.Forms.TextBox();
            this.BoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LFio = new System.Windows.Forms.Label();
            this.TFio = new System.Windows.Forms.TextBox();
            this.LNumberPhone = new System.Windows.Forms.Label();
            this.TNumberPhone = new System.Windows.Forms.TextBox();
            this.TestProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LNumber
            // 
            this.LNumber.AutoSize = true;
            this.LNumber.Location = new System.Drawing.Point(64, 11);
            this.LNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNumber.Name = "LNumber";
            this.LNumber.Size = new System.Drawing.Size(106, 17);
            this.LNumber.TabIndex = 0;
            this.LNumber.Text = "Номер заявки:";
            // 
            // TNumber
            // 
            this.TNumber.Location = new System.Drawing.Point(177, 8);
            this.TNumber.Name = "TNumber";
            this.TNumber.Size = new System.Drawing.Size(244, 25);
            this.TNumber.TabIndex = 1;
            this.TNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TNumber_KeyDown);
            // 
            // LDate
            // 
            this.LDate.AutoSize = true;
            this.LDate.Location = new System.Drawing.Point(125, 42);
            this.LDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDate.Name = "LDate";
            this.LDate.Size = new System.Drawing.Size(45, 17);
            this.LDate.TabIndex = 0;
            this.LDate.Text = "Дата:";
            // 
            // TDate
            // 
            this.TDate.Location = new System.Drawing.Point(177, 39);
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(244, 25);
            this.TDate.TabIndex = 1;
            // 
            // LNumberID
            // 
            this.LNumberID.AutoSize = true;
            this.LNumberID.Location = new System.Drawing.Point(46, 73);
            this.LNumberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNumberID.Name = "LNumberID";
            this.LNumberID.Size = new System.Drawing.Size(124, 17);
            this.LNumberID.TabIndex = 0;
            this.LNumberID.Text = "Номер абонента:";
            // 
            // TNumberID
            // 
            this.TNumberID.Location = new System.Drawing.Point(177, 70);
            this.TNumberID.Name = "TNumberID";
            this.TNumberID.Size = new System.Drawing.Size(244, 25);
            this.TNumberID.TabIndex = 1;
            // 
            // LCount
            // 
            this.LCount.AutoSize = true;
            this.LCount.Location = new System.Drawing.Point(64, 104);
            this.LCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(106, 17);
            this.LCount.TabIndex = 0;
            this.LCount.Text = "Лицевой счет:";
            // 
            // TCount
            // 
            this.TCount.Location = new System.Drawing.Point(177, 101);
            this.TCount.Name = "TCount";
            this.TCount.Size = new System.Drawing.Size(244, 25);
            this.TCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга:";
            // 
            // BoxUslug
            // 
            this.BoxUslug.FormattingEnabled = true;
            this.BoxUslug.Items.AddRange(new object[] {
            "Интернет",
            "Мобильная связь",
            "Телевидение",
            "Видеонаблюдение"});
            this.BoxUslug.Location = new System.Drawing.Point(177, 132);
            this.BoxUslug.Name = "BoxUslug";
            this.BoxUslug.Size = new System.Drawing.Size(244, 25);
            this.BoxUslug.TabIndex = 2;
            // 
            // LType
            // 
            this.LType.AutoSize = true;
            this.LType.Location = new System.Drawing.Point(84, 166);
            this.LType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LType.Name = "LType";
            this.LType.Size = new System.Drawing.Size(86, 17);
            this.LType.TabIndex = 0;
            this.LType.Text = "Вид услуги:";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Location = new System.Drawing.Point(110, 228);
            this.LStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(60, 17);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "Статус:";
            // 
            // BoxStatus
            // 
            this.BoxStatus.FormattingEnabled = true;
            this.BoxStatus.Items.AddRange(new object[] {
            "Новая",
            "Требует выезда",
            "Закрыта"});
            this.BoxStatus.Location = new System.Drawing.Point(177, 225);
            this.BoxStatus.Name = "BoxStatus";
            this.BoxStatus.Size = new System.Drawing.Size(244, 25);
            this.BoxStatus.TabIndex = 2;
            // 
            // LTypeOborud
            // 
            this.LTypeOborud.AutoSize = true;
            this.LTypeOborud.Location = new System.Drawing.Point(64, 247);
            this.LTypeOborud.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTypeOborud.Name = "LTypeOborud";
            this.LTypeOborud.Size = new System.Drawing.Size(109, 34);
            this.LTypeOborud.TabIndex = 0;
            this.LTypeOborud.Text = "        Тип\r\nоборудования:";
            // 
            // TTypeOborud
            // 
            this.TTypeOborud.Location = new System.Drawing.Point(177, 256);
            this.TTypeOborud.Name = "TTypeOborud";
            this.TTypeOborud.Size = new System.Drawing.Size(244, 25);
            this.TTypeOborud.TabIndex = 1;
            // 
            // LTypeProbl
            // 
            this.LTypeProbl.AutoSize = true;
            this.LTypeProbl.Location = new System.Drawing.Point(64, 287);
            this.LTypeProbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LTypeProbl.Name = "LTypeProbl";
            this.LTypeProbl.Size = new System.Drawing.Size(109, 17);
            this.LTypeProbl.TabIndex = 0;
            this.LTypeProbl.Text = "Тип проблемы:";
            // 
            // TTypeProbl
            // 
            this.TTypeProbl.Location = new System.Drawing.Point(177, 284);
            this.TTypeProbl.Name = "TTypeProbl";
            this.TTypeProbl.Size = new System.Drawing.Size(244, 25);
            this.TTypeProbl.TabIndex = 1;
            // 
            // LProbl
            // 
            this.LProbl.AutoSize = true;
            this.LProbl.Location = new System.Drawing.Point(20, 318);
            this.LProbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LProbl.Name = "LProbl";
            this.LProbl.Size = new System.Drawing.Size(153, 17);
            this.LProbl.TabIndex = 0;
            this.LProbl.Text = "Описание проблемы:";
            // 
            // TProbl
            // 
            this.TProbl.Location = new System.Drawing.Point(177, 315);
            this.TProbl.Name = "TProbl";
            this.TProbl.Size = new System.Drawing.Size(244, 25);
            this.TProbl.TabIndex = 1;
            // 
            // LDateClose
            // 
            this.LDateClose.AutoSize = true;
            this.LDateClose.Location = new System.Drawing.Point(57, 349);
            this.LDateClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDateClose.Name = "LDateClose";
            this.LDateClose.Size = new System.Drawing.Size(113, 17);
            this.LDateClose.TabIndex = 0;
            this.LDateClose.Text = "Дата закрытия:";
            // 
            // TDateClose
            // 
            this.TDateClose.Location = new System.Drawing.Point(177, 346);
            this.TDateClose.Name = "TDateClose";
            this.TDateClose.Size = new System.Drawing.Size(244, 25);
            this.TDateClose.TabIndex = 1;
            // 
            // BoxType
            // 
            this.BoxType.FormattingEnabled = true;
            this.BoxType.Items.AddRange(new object[] {
            "Подключение",
            "Управление договором/контактыми данными",
            "Управление тарифом/услугой",
            "Диагностика и настройка оборудования/подключение",
            "Оплата услуг"});
            this.BoxType.Location = new System.Drawing.Point(177, 163);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(244, 25);
            this.BoxType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип услуги:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Подключение услуг с новой инфраструктурой",
            "Подключение услуг на существующей инфраструктуре",
            "Изменение условий договора",
            "Включение в договор дополнительной услуги",
            "Изменение контактных данных",
            "Изменение тарифа",
            "Изменение адреса предоставления услуг",
            "Отключение услуги",
            "Приостановка предоставления услуги",
            "Нет доступа к услуге",
            "Разрыв соединения",
            "Низкая скорость соединения",
            "Выписка по платежам",
            "Информация о платежах",
            "Получение квитанции на оплату услуги"});
            this.comboBox2.Location = new System.Drawing.Point(177, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 25);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Протестировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LFio
            // 
            this.LFio.AutoSize = true;
            this.LFio.Location = new System.Drawing.Point(121, 477);
            this.LFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFio.Name = "LFio";
            this.LFio.Size = new System.Drawing.Size(46, 17);
            this.LFio.TabIndex = 0;
            this.LFio.Text = "ФИО:";
            // 
            // TFio
            // 
            this.TFio.Location = new System.Drawing.Point(177, 474);
            this.TFio.Name = "TFio";
            this.TFio.Size = new System.Drawing.Size(244, 25);
            this.TFio.TabIndex = 1;
            this.TFio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TNumber_KeyDown);
            // 
            // LNumberPhone
            // 
            this.LNumberPhone.AutoSize = true;
            this.LNumberPhone.Location = new System.Drawing.Point(41, 508);
            this.LNumberPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNumberPhone.Name = "LNumberPhone";
            this.LNumberPhone.Size = new System.Drawing.Size(126, 17);
            this.LNumberPhone.TabIndex = 0;
            this.LNumberPhone.Text = "Номер телефона:";
            // 
            // TNumberPhone
            // 
            this.TNumberPhone.Location = new System.Drawing.Point(177, 505);
            this.TNumberPhone.Name = "TNumberPhone";
            this.TNumberPhone.Size = new System.Drawing.Size(244, 25);
            this.TNumberPhone.TabIndex = 1;
            this.TNumberPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TNumber_KeyDown);
            // 
            // TestProgress
            // 
            this.TestProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.TestProgress.Location = new System.Drawing.Point(186, 568);
            this.TestProgress.Name = "TestProgress";
            this.TestProgress.Size = new System.Drawing.Size(298, 38);
            this.TestProgress.Step = 5;
            this.TestProgress.TabIndex = 4;
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 660);
            this.Controls.Add(this.TestProgress);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxStatus);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BoxType);
            this.Controls.Add(this.BoxUslug);
            this.Controls.Add(this.TDateClose);
            this.Controls.Add(this.TProbl);
            this.Controls.Add(this.TTypeProbl);
            this.Controls.Add(this.LDateClose);
            this.Controls.Add(this.TTypeOborud);
            this.Controls.Add(this.LProbl);
            this.Controls.Add(this.LTypeProbl);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LTypeOborud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TCount);
            this.Controls.Add(this.LType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LCount);
            this.Controls.Add(this.TNumberPhone);
            this.Controls.Add(this.LNumberPhone);
            this.Controls.Add(this.TFio);
            this.Controls.Add(this.LFio);
            this.Controls.Add(this.TNumberID);
            this.Controls.Add(this.LNumberID);
            this.Controls.Add(this.TDate);
            this.Controls.Add(this.LDate);
            this.Controls.Add(this.TNumber);
            this.Controls.Add(this.LNumber);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRM";
            this.Text = "Телеком Нева Связь";
            this.Load += new System.EventHandler(this.CRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNumber;
        private System.Windows.Forms.TextBox TNumber;
        private System.Windows.Forms.Label LDate;
        private System.Windows.Forms.TextBox TDate;
        private System.Windows.Forms.Label LNumberID;
        private System.Windows.Forms.TextBox TNumberID;
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.TextBox TCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxUslug;
        private System.Windows.Forms.Label LType;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.ComboBox BoxStatus;
        private System.Windows.Forms.Label LTypeOborud;
        private System.Windows.Forms.TextBox TTypeOborud;
        private System.Windows.Forms.Label LTypeProbl;
        private System.Windows.Forms.TextBox TTypeProbl;
        private System.Windows.Forms.Label LProbl;
        private System.Windows.Forms.TextBox TProbl;
        private System.Windows.Forms.Label LDateClose;
        private System.Windows.Forms.TextBox TDateClose;
        private System.Windows.Forms.ComboBox BoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LFio;
        private System.Windows.Forms.TextBox TFio;
        private System.Windows.Forms.Label LNumberPhone;
        private System.Windows.Forms.TextBox TNumberPhone;
        private System.Windows.Forms.ProgressBar TestProgress;
    }
}