namespace ws09
{
    partial class Postavhiki
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavhiki));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inn = new System.Windows.Forms.TextBox();
            this.reyt = new System.Windows.Forms.TextBox();
            this.naimen = new System.Windows.Forms.TextBox();
            this.kod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wsdemo9DataSet5 = new ws09.wsdemo9DataSet5();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new ws09.wsdemo9DataSet5TableAdapters.ПоставщикиTableAdapter();
            this.kodpostavhikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovaniepostavhikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tippostavhikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reytingkahestvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanahalarabotispostavhikomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.TextBox();
            this.dat = new System.Windows.Forms.DateTimePicker();
            this.NaGlavn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Sev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ws09.Properties.Resources.Большая_пачка;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // inn
            // 
            this.inn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.inn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(366, 130);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(124, 23);
            this.inn.TabIndex = 34;
            // 
            // reyt
            // 
            this.reyt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.reyt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reyt.Location = new System.Drawing.Point(366, 164);
            this.reyt.Name = "reyt";
            this.reyt.Size = new System.Drawing.Size(124, 23);
            this.reyt.TabIndex = 33;
            // 
            // naimen
            // 
            this.naimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.naimen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naimen.Location = new System.Drawing.Point(366, 63);
            this.naimen.Name = "naimen";
            this.naimen.Size = new System.Drawing.Size(124, 23);
            this.naimen.TabIndex = 31;
            // 
            // kod
            // 
            this.kod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.kod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kod.Location = new System.Drawing.Point(366, 22);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(124, 23);
            this.kod.TabIndex = 30;
            this.kod.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(135, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Дата начала работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(135, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(135, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Рейтинг поставщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(135, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Тип поставщика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Код_поставщика";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodpostavhikaDataGridViewTextBoxColumn,
            this.naimenovaniepostavhikaDataGridViewTextBoxColumn,
            this.tippostavhikaDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.reytingkahestvaDataGridViewTextBoxColumn,
            this.datanahalarabotispostavhikomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставщикиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(115, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 212);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // wsdemo9DataSet5
            // 
            this.wsdemo9DataSet5.DataSetName = "wsdemo9DataSet5";
            this.wsdemo9DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.wsdemo9DataSet5;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // kodpostavhikaDataGridViewTextBoxColumn
            // 
            this.kodpostavhikaDataGridViewTextBoxColumn.DataPropertyName = "Kod_postavhika";
            this.kodpostavhikaDataGridViewTextBoxColumn.HeaderText = "Kod_postavhika";
            this.kodpostavhikaDataGridViewTextBoxColumn.Name = "kodpostavhikaDataGridViewTextBoxColumn";
            this.kodpostavhikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naimenovaniepostavhikaDataGridViewTextBoxColumn
            // 
            this.naimenovaniepostavhikaDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_postavhika";
            this.naimenovaniepostavhikaDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_postavhika";
            this.naimenovaniepostavhikaDataGridViewTextBoxColumn.Name = "naimenovaniepostavhikaDataGridViewTextBoxColumn";
            // 
            // tippostavhikaDataGridViewTextBoxColumn
            // 
            this.tippostavhikaDataGridViewTextBoxColumn.DataPropertyName = "Tip_postavhika";
            this.tippostavhikaDataGridViewTextBoxColumn.HeaderText = "Tip_postavhika";
            this.tippostavhikaDataGridViewTextBoxColumn.Name = "tippostavhikaDataGridViewTextBoxColumn";
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            // 
            // reytingkahestvaDataGridViewTextBoxColumn
            // 
            this.reytingkahestvaDataGridViewTextBoxColumn.DataPropertyName = "Reyting_kahestva";
            this.reytingkahestvaDataGridViewTextBoxColumn.HeaderText = "Reyting_kahestva";
            this.reytingkahestvaDataGridViewTextBoxColumn.Name = "reytingkahestvaDataGridViewTextBoxColumn";
            // 
            // datanahalarabotispostavhikomDataGridViewTextBoxColumn
            // 
            this.datanahalarabotispostavhikomDataGridViewTextBoxColumn.DataPropertyName = "Data_nahala_raboti_s_postavhikom";
            this.datanahalarabotispostavhikomDataGridViewTextBoxColumn.HeaderText = "Data_nahala_raboti_s_postavhikom";
            this.datanahalarabotispostavhikomDataGridViewTextBoxColumn.Name = "datanahalarabotispostavhikomDataGridViewTextBoxColumn";
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tip.Location = new System.Drawing.Point(366, 97);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(124, 23);
            this.tip.TabIndex = 37;
            // 
            // dat
            // 
            this.dat.Location = new System.Drawing.Point(366, 198);
            this.dat.Name = "dat";
            this.dat.Size = new System.Drawing.Size(124, 20);
            this.dat.TabIndex = 38;
            // 
            // NaGlavn
            // 
            this.NaGlavn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.NaGlavn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NaGlavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.NaGlavn.Location = new System.Drawing.Point(795, 12);
            this.NaGlavn.Name = "NaGlavn";
            this.NaGlavn.Size = new System.Drawing.Size(131, 37);
            this.NaGlavn.TabIndex = 39;
            this.NaGlavn.Text = "На главную";
            this.NaGlavn.UseVisualStyleBackColor = false;
            this.NaGlavn.Click += new System.EventHandler(this.NaGlavn_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.clear.Location = new System.Drawing.Point(454, 250);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(166, 47);
            this.clear.TabIndex = 42;
            this.clear.Text = "Отчистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Sev
            // 
            this.Sev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.Sev.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.Sev.Location = new System.Drawing.Point(245, 250);
            this.Sev.Name = "Sev";
            this.Sev.Size = new System.Drawing.Size(166, 47);
            this.Sev.TabIndex = 41;
            this.Sev.Text = "Сохранить";
            this.Sev.UseVisualStyleBackColor = false;
            this.Sev.Click += new System.EventHandler(this.Sev_Click);
            // 
            // Postavhiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Sev);
            this.Controls.Add(this.NaGlavn);
            this.Controls.Add(this.dat);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.reyt);
            this.Controls.Add(this.naimen);
            this.Controls.Add(this.kod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postavhiki";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Postavhiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inn;
        private System.Windows.Forms.TextBox reyt;
        private System.Windows.Forms.TextBox naimen;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private wsdemo9DataSet5 wsdemo9DataSet5;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private wsdemo9DataSet5TableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodpostavhikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovaniepostavhikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tippostavhikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reytingkahestvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanahalarabotispostavhikomDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tip;
        private System.Windows.Forms.DateTimePicker dat;
        private System.Windows.Forms.Button NaGlavn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Sev;
    }
}