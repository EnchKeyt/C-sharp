namespace ws09
{
    partial class Material
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Material));
            this.Mater = new System.Windows.Forms.DataGridView();
            this.wsdemo9DataSet1 = new ws09.wsdemo9DataSet1();
            this.материалыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.материалыTableAdapter = new ws09.wsdemo9DataSet1TableAdapters.МатериалыTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.wsdemo9DataSet2 = new ws09.wsdemo9DataSet2();
            this.материалыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.материалыTableAdapter1 = new ws09.wsdemo9DataSet2TableAdapters.МатериалыTableAdapter();
            this.wsdemo9DataSet4 = new ws09.wsdemo9DataSet4();
            this.материалыBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.материалыTableAdapter2 = new ws09.wsdemo9DataSet4TableAdapters.МатериалыTableAdapter();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource2)).BeginInit();
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
            this.Mater.DataSource = this.материалыBindingSource2;
            this.Mater.Location = new System.Drawing.Point(-6, 341);
            this.Mater.Name = "Mater";
            this.Mater.Size = new System.Drawing.Size(949, 169);
            this.Mater.TabIndex = 3;
            // 
            // wsdemo9DataSet1
            // 
            this.wsdemo9DataSet1.DataSetName = "wsdemo9DataSet1";
            this.wsdemo9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыBindingSource
            // 
            this.материалыBindingSource.DataMember = "Материалы";
            this.материалыBindingSource.DataSource = this.wsdemo9DataSet1;
            // 
            // материалыTableAdapter
            // 
            this.материалыTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button1.Location = new System.Drawing.Point(360, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button2.Location = new System.Drawing.Point(360, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 84);
            this.button2.TabIndex = 5;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button3.Location = new System.Drawing.Point(360, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 84);
            this.button3.TabIndex = 6;
            this.button3.Text = "На главную";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // wsdemo9DataSet2
            // 
            this.wsdemo9DataSet2.DataSetName = "wsdemo9DataSet2";
            this.wsdemo9DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыBindingSource1
            // 
            this.материалыBindingSource1.DataMember = "Материалы";
            this.материалыBindingSource1.DataSource = this.wsdemo9DataSet2;
            // 
            // материалыTableAdapter1
            // 
            this.материалыTableAdapter1.ClearBeforeFill = true;
            // 
            // wsdemo9DataSet4
            // 
            this.wsdemo9DataSet4.DataSetName = "wsdemo9DataSet4";
            this.wsdemo9DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалыBindingSource2
            // 
            this.материалыBindingSource2.DataMember = "Материалы";
            this.материалыBindingSource2.DataSource = this.wsdemo9DataSet4;
            // 
            // материалыTableAdapter2
            // 
            this.материалыTableAdapter2.ClearBeforeFill = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ws09.Properties.Resources.Большая_пачка;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 509);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mater);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Material";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.Material_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Mater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo9DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалыBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Mater;
        private wsdemo9DataSet1 wsdemo9DataSet1;
        private System.Windows.Forms.BindingSource материалыBindingSource;
        private wsdemo9DataSet1TableAdapters.МатериалыTableAdapter материалыTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private wsdemo9DataSet2 wsdemo9DataSet2;
        private System.Windows.Forms.BindingSource материалыBindingSource1;
        private wsdemo9DataSet2TableAdapters.МатериалыTableAdapter материалыTableAdapter1;
        private wsdemo9DataSet4 wsdemo9DataSet4;
        private System.Windows.Forms.BindingSource материалыBindingSource2;
        private wsdemo9DataSet4TableAdapters.МатериалыTableAdapter материалыTableAdapter2;
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
    }
}