namespace ws09
{
    partial class RedaktirovanMater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedaktirovanMater));
            this.Mater = new System.Windows.Forms.DataGridView();
            this.kodmaterialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naimenovaniematerialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipmaterialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izobragenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvonaskladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minkolichestvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolichestvovupakovkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edinizaizmereniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opicanieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsdemo9DataSet4 = new ws09.wsdemo9DataSet4();
            this.материалыTableAdapter = new ws09.wsdemo9DataSet4TableAdapters.МатериалыTableAdapter();
            this.Nazad = new System.Windows.Forms.Button();
            this.NaGlavn = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.ComboBox();
            this.Red = new System.Windows.Forms.Button();
            this.colich = new System.Windows.Forms.TextBox();
            this.stoim = new System.Windows.Forms.TextBox();
            this.minCol = new System.Windows.Forms.TextBox();
            this.edIzm = new System.Windows.Forms.TextBox();
            this.opis = new System.Windows.Forms.TextBox();
            this.colVU = new System.Windows.Forms.TextBox();
            this.naimen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Mater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mater
            // 
            this.Mater.AutoGenerateColumns = false;
            this.Mater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mater.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodmaterialaDataGridViewTextBoxColumn,
            this.naimenovaniematerialaDataGridViewTextBoxColumn,
            this.tipmaterialaDataGridViewTextBoxColumn,
            this.izobragenieDataGridViewTextBoxColumn,
            this.zenaDataGridViewTextBoxColumn,
            this.kolichestvonaskladeDataGridViewTextBoxColumn,
            this.minkolichestvoDataGridViewTextBoxColumn,
            this.kolichestvovupakovkeDataGridViewTextBoxColumn,
            this.edinizaizmereniaDataGridViewTextBoxColumn,
            this.opicanieDataGridViewTextBoxColumn});
            this.Mater.DataSource = this.материалыBindingSource;
            this.Mater.Location = new System.Drawing.Point(-14, 372);
            this.Mater.Name = "Mater";
            this.Mater.Size = new System.Drawing.Size(952, 135);
            this.Mater.TabIndex = 4;
            this.Mater.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Mater_CellClick);
            // 
            // kodmaterialaDataGridViewTextBoxColumn
            // 
            this.kodmaterialaDataGridViewTextBoxColumn.DataPropertyName = "Kod_materiala";
            this.kodmaterialaDataGridViewTextBoxColumn.HeaderText = "Kod_materiala";
            this.kodmaterialaDataGridViewTextBoxColumn.Name = "kodmaterialaDataGridViewTextBoxColumn";
            this.kodmaterialaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // naimenovaniematerialaDataGridViewTextBoxColumn
            // 
            this.naimenovaniematerialaDataGridViewTextBoxColumn.DataPropertyName = "Naimenovanie_materiala";
            this.naimenovaniematerialaDataGridViewTextBoxColumn.HeaderText = "Naimenovanie_materiala";
            this.naimenovaniematerialaDataGridViewTextBoxColumn.Name = "naimenovaniematerialaDataGridViewTextBoxColumn";
            // 
            // tipmaterialaDataGridViewTextBoxColumn
            // 
            this.tipmaterialaDataGridViewTextBoxColumn.DataPropertyName = "Tip_materiala";
            this.tipmaterialaDataGridViewTextBoxColumn.HeaderText = "Tip_materiala";
            this.tipmaterialaDataGridViewTextBoxColumn.Name = "tipmaterialaDataGridViewTextBoxColumn";
            // 
            // izobragenieDataGridViewTextBoxColumn
            // 
            this.izobragenieDataGridViewTextBoxColumn.DataPropertyName = "Izobragenie";
            this.izobragenieDataGridViewTextBoxColumn.HeaderText = "Izobragenie";
            this.izobragenieDataGridViewTextBoxColumn.Name = "izobragenieDataGridViewTextBoxColumn";
            // 
            // zenaDataGridViewTextBoxColumn
            // 
            this.zenaDataGridViewTextBoxColumn.DataPropertyName = "Zena";
            this.zenaDataGridViewTextBoxColumn.HeaderText = "Zena";
            this.zenaDataGridViewTextBoxColumn.Name = "zenaDataGridViewTextBoxColumn";
            // 
            // kolichestvonaskladeDataGridViewTextBoxColumn
            // 
            this.kolichestvonaskladeDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo_na_sklade";
            this.kolichestvonaskladeDataGridViewTextBoxColumn.HeaderText = "Kolichestvo_na_sklade";
            this.kolichestvonaskladeDataGridViewTextBoxColumn.Name = "kolichestvonaskladeDataGridViewTextBoxColumn";
            // 
            // minkolichestvoDataGridViewTextBoxColumn
            // 
            this.minkolichestvoDataGridViewTextBoxColumn.DataPropertyName = "Min_kolichestvo";
            this.minkolichestvoDataGridViewTextBoxColumn.HeaderText = "Min_kolichestvo";
            this.minkolichestvoDataGridViewTextBoxColumn.Name = "minkolichestvoDataGridViewTextBoxColumn";
            // 
            // kolichestvovupakovkeDataGridViewTextBoxColumn
            // 
            this.kolichestvovupakovkeDataGridViewTextBoxColumn.DataPropertyName = "Kolichestvo_v_upakovke";
            this.kolichestvovupakovkeDataGridViewTextBoxColumn.HeaderText = "Kolichestvo_v_upakovke";
            this.kolichestvovupakovkeDataGridViewTextBoxColumn.Name = "kolichestvovupakovkeDataGridViewTextBoxColumn";
            // 
            // edinizaizmereniaDataGridViewTextBoxColumn
            // 
            this.edinizaizmereniaDataGridViewTextBoxColumn.DataPropertyName = "Ediniza_izmerenia";
            this.edinizaizmereniaDataGridViewTextBoxColumn.HeaderText = "Ediniza_izmerenia";
            this.edinizaizmereniaDataGridViewTextBoxColumn.Name = "edinizaizmereniaDataGridViewTextBoxColumn";
            // 
            // opicanieDataGridViewTextBoxColumn
            // 
            this.opicanieDataGridViewTextBoxColumn.DataPropertyName = "Opicanie";
            this.opicanieDataGridViewTextBoxColumn.HeaderText = "Opicanie";
            this.opicanieDataGridViewTextBoxColumn.Name = "opicanieDataGridViewTextBoxColumn";
            // 
            // материалыBindingSource
            // 
            this.материалыBindingSource.DataMember = "Материалы";
            this.материалыBindingSource.DataSource = this.wsdemo9DataSet4;
            // 
            // wsdemo9DataSet4
            // 
            this.wsdemo9DataSet4.DataSetName = "wsdemo9DataSet4";
            this.wsdemo9DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыTableAdapter
            // 
            this.материалыTableAdapter.ClearBeforeFill = true;
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.Nazad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.Nazad.Location = new System.Drawing.Point(795, 14);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(131, 37);
            this.Nazad.TabIndex = 45;
            this.Nazad.Text = "Назад";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // NaGlavn
            // 
            this.NaGlavn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.NaGlavn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NaGlavn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.NaGlavn.Location = new System.Drawing.Point(795, 56);
            this.NaGlavn.Name = "NaGlavn";
            this.NaGlavn.Size = new System.Drawing.Size(131, 37);
            this.NaGlavn.TabIndex = 44;
            this.NaGlavn.Text = "На главную";
            this.NaGlavn.UseVisualStyleBackColor = false;
            this.NaGlavn.Click += new System.EventHandler(this.NaGlavn_Click);
            // 
            // tip
            // 
            this.tip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.tip.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tip.FormattingEnabled = true;
            this.tip.Items.AddRange(new object[] {
            "Granuli",
            "Kraski",
            "Nitki"});
            this.tip.Location = new System.Drawing.Point(367, 44);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(124, 24);
            this.tip.TabIndex = 43;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.Red.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.Red.Location = new System.Drawing.Point(195, 319);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(166, 47);
            this.Red.TabIndex = 42;
            this.Red.Text = "Изменить";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // colich
            // 
            this.colich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.colich.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colich.Location = new System.Drawing.Point(367, 76);
            this.colich.Name = "colich";
            this.colich.Size = new System.Drawing.Size(124, 23);
            this.colich.TabIndex = 41;
            // 
            // stoim
            // 
            this.stoim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.stoim.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoim.Location = new System.Drawing.Point(367, 228);
            this.stoim.Name = "stoim";
            this.stoim.Size = new System.Drawing.Size(124, 23);
            this.stoim.TabIndex = 40;
            // 
            // minCol
            // 
            this.minCol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.minCol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCol.Location = new System.Drawing.Point(367, 265);
            this.minCol.Name = "minCol";
            this.minCol.Size = new System.Drawing.Size(124, 23);
            this.minCol.TabIndex = 39;
            // 
            // edIzm
            // 
            this.edIzm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.edIzm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edIzm.Location = new System.Drawing.Point(367, 110);
            this.edIzm.Name = "edIzm";
            this.edIzm.Size = new System.Drawing.Size(124, 23);
            this.edIzm.TabIndex = 38;
            // 
            // opis
            // 
            this.opis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.opis.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opis.Location = new System.Drawing.Point(367, 148);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(124, 23);
            this.opis.TabIndex = 37;
            // 
            // colVU
            // 
            this.colVU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.colVU.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colVU.Location = new System.Drawing.Point(367, 190);
            this.colVU.Name = "colVU";
            this.colVU.Size = new System.Drawing.Size(124, 23);
            this.colVU.TabIndex = 36;
            // 
            // naimen
            // 
            this.naimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.naimen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.naimen.Location = new System.Drawing.Point(367, 10);
            this.naimen.Name = "naimen";
            this.naimen.Size = new System.Drawing.Size(124, 23);
            this.naimen.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(136, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Подробное описание";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(627, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Изображение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(139, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "Стоимость за единицу";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(139, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Минимальное колечество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(136, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Количество в упаковке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(136, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Единица измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(136, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Количество на складе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Тип материала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Наименование";
            // 
            // Kod
            // 
            this.Kod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.Kod.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kod.Location = new System.Drawing.Point(762, 222);
            this.Kod.Name = "Kod";
            this.Kod.Size = new System.Drawing.Size(124, 23);
            this.Kod.TabIndex = 47;
            this.Kod.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(612, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Код_материала";
            this.label10.Visible = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.delete.Location = new System.Drawing.Point(583, 319);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(166, 47);
            this.delete.TabIndex = 48;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ws09.Properties.Resources.Большая_пачка;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.clear.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.clear.Location = new System.Drawing.Point(383, 319);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(166, 47);
            this.clear.TabIndex = 49;
            this.clear.Text = "Отчистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // RedaktirovanMater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Kod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.NaGlavn);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.colich);
            this.Controls.Add(this.stoim);
            this.Controls.Add(this.minCol);
            this.Controls.Add(this.edIzm);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.colVU);
            this.Controls.Add(this.naimen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mater);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedaktirovanMater";
            this.Text = "Редактирование материалов";
            this.Load += new System.EventHandler(this.RedaktirovanMater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Mater;
        private wsdemo9DataSet4 wsdemo9DataSet4;
        private System.Windows.Forms.BindingSource материалыBindingSource;
        private wsdemo9DataSet4TableAdapters.МатериалыTableAdapter материалыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodmaterialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naimenovaniematerialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipmaterialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn izobragenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvonaskladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minkolichestvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolichestvovupakovkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edinizaizmereniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opicanieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button NaGlavn;
        private System.Windows.Forms.ComboBox tip;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.TextBox colich;
        private System.Windows.Forms.TextBox stoim;
        private System.Windows.Forms.TextBox minCol;
        private System.Windows.Forms.TextBox edIzm;
        private System.Windows.Forms.TextBox opis;
        private System.Windows.Forms.TextBox colVU;
        private System.Windows.Forms.TextBox naimen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
    }
}