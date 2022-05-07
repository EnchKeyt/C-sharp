namespace wsdemo10
{
    partial class Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.наименованиематериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типматериалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествовупаковкеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествонаскладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйвозможныйостатокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.материалынаскладеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsdemo10DataSet = new wsdemo10.wsdemo10DataSet();
            this.материалы_на_складеTableAdapter = new wsdemo10.wsdemo10DataSetTableAdapters.Материалы_на_складеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалынаскладеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo10DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиематериалаDataGridViewTextBoxColumn,
            this.типматериалаDataGridViewTextBoxColumn,
            this.количествовупаковкеDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.количествонаскладеDataGridViewTextBoxColumn,
            this.минимальныйвозможныйостатокDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.материалынаскладеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.add_btn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.add_btn.Location = new System.Drawing.Point(53, 31);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 40);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.delete_btn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.delete_btn.Location = new System.Drawing.Point(199, 31);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 40);
            this.delete_btn.TabIndex = 2;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // izmenit_btn
            // 
            this.izmenit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.izmenit_btn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.izmenit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.izmenit_btn.Location = new System.Drawing.Point(348, 31);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(75, 40);
            this.izmenit_btn.TabIndex = 3;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = false;
            this.izmenit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.backbtn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.backbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.backbtn.Location = new System.Drawing.Point(479, 31);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 40);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Назад";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(688, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // наименованиематериалаDataGridViewTextBoxColumn
            // 
            this.наименованиематериалаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.HeaderText = "Наименование_материала";
            this.наименованиематериалаDataGridViewTextBoxColumn.Name = "наименованиематериалаDataGridViewTextBoxColumn";
            // 
            // типматериалаDataGridViewTextBoxColumn
            // 
            this.типматериалаDataGridViewTextBoxColumn.DataPropertyName = "Тип_материала";
            this.типматериалаDataGridViewTextBoxColumn.HeaderText = "Тип_материала";
            this.типматериалаDataGridViewTextBoxColumn.Name = "типматериалаDataGridViewTextBoxColumn";
            // 
            // количествовупаковкеDataGridViewTextBoxColumn
            // 
            this.количествовупаковкеDataGridViewTextBoxColumn.DataPropertyName = "Количество_в_упаковке";
            this.количествовупаковкеDataGridViewTextBoxColumn.HeaderText = "Количество_в_упаковке";
            this.количествовупаковкеDataGridViewTextBoxColumn.Name = "количествовупаковкеDataGridViewTextBoxColumn";
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            // 
            // количествонаскладеDataGridViewTextBoxColumn
            // 
            this.количествонаскладеDataGridViewTextBoxColumn.DataPropertyName = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.HeaderText = "Количество_на_складе";
            this.количествонаскладеDataGridViewTextBoxColumn.Name = "количествонаскладеDataGridViewTextBoxColumn";
            // 
            // минимальныйвозможныйостатокDataGridViewTextBoxColumn
            // 
            this.минимальныйвозможныйостатокDataGridViewTextBoxColumn.DataPropertyName = "Минимальный_возможный_остаток";
            this.минимальныйвозможныйостатокDataGridViewTextBoxColumn.HeaderText = "Минимальный_возможный_остаток";
            this.минимальныйвозможныйостатокDataGridViewTextBoxColumn.Name = "минимальныйвозможныйостатокDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // материалынаскладеBindingSource
            // 
            this.материалынаскладеBindingSource.DataMember = "Материалы_на_складе";
            this.материалынаскладеBindingSource.DataSource = this.wsdemo10DataSet;
            // 
            // wsdemo10DataSet
            // 
            this.wsdemo10DataSet.DataSetName = "wsdemo10DataSet";
            this.wsdemo10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // материалы_на_складеTableAdapter
            // 
            this.материалы_на_складеTableAdapter.ClearBeforeFill = true;
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Materials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы на складе";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.материалынаскладеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo10DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private wsdemo10DataSet wsdemo10DataSet;
        private System.Windows.Forms.BindingSource материалынаскладеBindingSource;
        private wsdemo10DataSetTableAdapters.Материалы_на_складеTableAdapter материалы_на_складеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиематериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типматериалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествовупаковкеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествонаскладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйвозможныйостатокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}