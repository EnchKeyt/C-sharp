
namespace OOO_Telecom_Neva_Svyaz
{
    partial class Abonent
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCRM = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonPodderzka = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAbonent = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonBilling = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonAktiv = new System.Windows.Forms.Button();
            this.buttonUprAborudov = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGVabonent = new System.Windows.Forms.DataGridView();
            this.comboBoxPolzovateli = new System.Windows.Forms.ComboBox();
            this.sotrudnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ws02DataSet = new OOO_Telecom_Neva_Svyaz.ws02DataSet();
            this.pictureBoxpolzovateli = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sotrudnikTableAdapter = new OOO_Telecom_Neva_Svyaz.ws02DataSetTableAdapters.SotrudnikTableAdapter();
            this.radioButtonActiv = new System.Windows.Forms.RadioButton();
            this.radioButtonNeActiv = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVabonent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpolzovateli)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonCRM);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.buttonPodderzka);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.buttonAbonent);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.buttonBilling);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.buttonAktiv);
            this.panel1.Controls.Add(this.buttonUprAborudov);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 518);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 271);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            this.pictureBox5.Click += new System.EventHandler(this.buttonBilling_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(42, 457);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "Меню";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonCRM
            // 
            this.buttonCRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonCRM.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonCRM.Location = new System.Drawing.Point(16, 379);
            this.buttonCRM.Name = "buttonCRM";
            this.buttonCRM.Size = new System.Drawing.Size(109, 46);
            this.buttonCRM.TabIndex = 34;
            this.buttonCRM.Text = "CRM";
            this.buttonCRM.UseVisualStyleBackColor = false;
            this.buttonCRM.Click += new System.EventHandler(this.buttonCRM_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(11, 171);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 42);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 39;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // buttonPodderzka
            // 
            this.buttonPodderzka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonPodderzka.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPodderzka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonPodderzka.Location = new System.Drawing.Point(16, 327);
            this.buttonPodderzka.Name = "buttonPodderzka";
            this.buttonPodderzka.Size = new System.Drawing.Size(109, 46);
            this.buttonPodderzka.TabIndex = 33;
            this.buttonPodderzka.Text = "Поддержка\r\nпользователей";
            this.buttonPodderzka.UseVisualStyleBackColor = false;
            this.buttonPodderzka.Click += new System.EventHandler(this.buttonPodderzka_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 375);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buttonAbonent
            // 
            this.buttonAbonent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonAbonent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbonent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonAbonent.Location = new System.Drawing.Point(16, 123);
            this.buttonAbonent.Name = "buttonAbonent";
            this.buttonAbonent.Size = new System.Drawing.Size(109, 46);
            this.buttonAbonent.TabIndex = 29;
            this.buttonAbonent.Text = "Абоненты";
            this.buttonAbonent.UseVisualStyleBackColor = false;
            this.buttonAbonent.Click += new System.EventHandler(this.buttonAbonent_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(11, 323);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 42);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 38;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            this.pictureBox6.Click += new System.EventHandler(this.buttonPodderzka_Click);
            // 
            // buttonBilling
            // 
            this.buttonBilling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonBilling.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBilling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonBilling.Location = new System.Drawing.Point(16, 275);
            this.buttonBilling.Name = "buttonBilling";
            this.buttonBilling.Size = new System.Drawing.Size(109, 46);
            this.buttonBilling.TabIndex = 32;
            this.buttonBilling.Text = "Биллинг";
            this.buttonBilling.UseVisualStyleBackColor = false;
            this.buttonBilling.Click += new System.EventHandler(this.buttonBilling_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // buttonAktiv
            // 
            this.buttonAktiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonAktiv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAktiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonAktiv.Location = new System.Drawing.Point(16, 223);
            this.buttonAktiv.Name = "buttonAktiv";
            this.buttonAktiv.Size = new System.Drawing.Size(109, 46);
            this.buttonAktiv.TabIndex = 31;
            this.buttonAktiv.Text = "Активы";
            this.buttonAktiv.UseVisualStyleBackColor = false;
            // 
            // buttonUprAborudov
            // 
            this.buttonUprAborudov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonUprAborudov.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUprAborudov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonUprAborudov.Location = new System.Drawing.Point(16, 171);
            this.buttonUprAborudov.Name = "buttonUprAborudov";
            this.buttonUprAborudov.Size = new System.Drawing.Size(109, 46);
            this.buttonUprAborudov.TabIndex = 30;
            this.buttonUprAborudov.Text = "Управление\r\nоборудованием";
            this.buttonUprAborudov.UseVisualStyleBackColor = false;
            this.buttonUprAborudov.Click += new System.EventHandler(this.buttonUprAborudov_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGVabonent
            // 
            this.dataGVabonent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.dataGVabonent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVabonent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVabonent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.dataGVabonent.Location = new System.Drawing.Point(148, 167);
            this.dataGVabonent.Name = "dataGVabonent";
            this.dataGVabonent.Size = new System.Drawing.Size(499, 305);
            this.dataGVabonent.TabIndex = 1;
            // 
            // comboBoxPolzovateli
            // 
            this.comboBoxPolzovateli.DataSource = this.sotrudnikBindingSource;
            this.comboBoxPolzovateli.DisplayMember = "FIO";
            this.comboBoxPolzovateli.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPolzovateli.FormattingEnabled = true;
            this.comboBoxPolzovateli.Location = new System.Drawing.Point(527, 42);
            this.comboBoxPolzovateli.Name = "comboBoxPolzovateli";
            this.comboBoxPolzovateli.Size = new System.Drawing.Size(158, 24);
            this.comboBoxPolzovateli.TabIndex = 2;
            this.comboBoxPolzovateli.SelectedIndexChanged += new System.EventHandler(this.comboBoxPolzovateli_SelectedIndexChanged);
            // 
            // sotrudnikBindingSource
            // 
            this.sotrudnikBindingSource.DataMember = "Sotrudnik";
            this.sotrudnikBindingSource.DataSource = this.ws02DataSet;
            // 
            // ws02DataSet
            // 
            this.ws02DataSet.DataSetName = "ws02DataSet";
            this.ws02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBoxpolzovateli
            // 
            this.pictureBoxpolzovateli.Location = new System.Drawing.Point(691, 12);
            this.pictureBoxpolzovateli.Name = "pictureBoxpolzovateli";
            this.pictureBoxpolzovateli.Size = new System.Drawing.Size(102, 77);
            this.pictureBoxpolzovateli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxpolzovateli.TabIndex = 3;
            this.pictureBoxpolzovateli.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Абоненты ТНС";
            // 
            // sotrudnikTableAdapter
            // 
            this.sotrudnikTableAdapter.ClearBeforeFill = true;
            // 
            // radioButtonActiv
            // 
            this.radioButtonActiv.AutoSize = true;
            this.radioButtonActiv.Location = new System.Drawing.Point(177, 478);
            this.radioButtonActiv.Name = "radioButtonActiv";
            this.radioButtonActiv.Size = new System.Drawing.Size(75, 17);
            this.radioButtonActiv.TabIndex = 5;
            this.radioButtonActiv.TabStop = true;
            this.radioButtonActiv.Text = "Активные";
            this.radioButtonActiv.UseVisualStyleBackColor = true;
            this.radioButtonActiv.CheckedChanged += new System.EventHandler(this.radioButtonActiv_CheckedChanged);
            // 
            // radioButtonNeActiv
            // 
            this.radioButtonNeActiv.AutoSize = true;
            this.radioButtonNeActiv.Location = new System.Drawing.Point(389, 478);
            this.radioButtonNeActiv.Name = "radioButtonNeActiv";
            this.radioButtonNeActiv.Size = new System.Drawing.Size(88, 17);
            this.radioButtonNeActiv.TabIndex = 6;
            this.radioButtonNeActiv.TabStop = true;
            this.radioButtonNeActiv.Text = "Неактивные";
            this.radioButtonNeActiv.UseVisualStyleBackColor = true;
            // 
            // Abonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 510);
            this.Controls.Add(this.radioButtonNeActiv);
            this.Controls.Add(this.radioButtonActiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxpolzovateli);
            this.Controls.Add(this.comboBoxPolzovateli);
            this.Controls.Add(this.dataGVabonent);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abonent";
            this.Text = "Абоненты ТНС";
            this.Load += new System.EventHandler(this.Abonent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVabonent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpolzovateli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGVabonent;
        private System.Windows.Forms.ComboBox comboBoxPolzovateli;
        private System.Windows.Forms.PictureBox pictureBoxpolzovateli;
        private System.Windows.Forms.Label label1;
        private ws02DataSet ws02DataSet;
        private System.Windows.Forms.BindingSource sotrudnikBindingSource;
        private ws02DataSetTableAdapters.SotrudnikTableAdapter sotrudnikTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonActiv;
        private System.Windows.Forms.RadioButton radioButtonNeActiv;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCRM;
        private System.Windows.Forms.Button buttonPodderzka;
        private System.Windows.Forms.Button buttonAbonent;
        private System.Windows.Forms.Button buttonBilling;
        private System.Windows.Forms.Button buttonAktiv;
        private System.Windows.Forms.Button buttonUprAborudov;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

