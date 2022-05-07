namespace wsdemo10
{
    partial class ImageProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProduct));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.izmenit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.артикулDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продуктыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wsdemo10DataSet = new wsdemo10.wsdemo10DataSet();
            this.продуктBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продуктTableAdapter = new wsdemo10.wsdemo10DataSetTableAdapters.ПродуктTableAdapter();
            this.продуктыTableAdapter = new wsdemo10.wsdemo10DataSetTableAdapters.ПродуктыTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo10DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.артикулDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продуктыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.add_btn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.add_btn.Location = new System.Drawing.Point(302, 47);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(91, 54);
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
            this.delete_btn.Location = new System.Drawing.Point(302, 209);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(91, 54);
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
            this.izmenit_btn.Location = new System.Drawing.Point(302, 361);
            this.izmenit_btn.Name = "izmenit_btn";
            this.izmenit_btn.Size = new System.Drawing.Size(91, 54);
            this.izmenit_btn.TabIndex = 3;
            this.izmenit_btn.Text = "Изменить";
            this.izmenit_btn.UseVisualStyleBackColor = false;
            this.izmenit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.back_btn.Font = new System.Drawing.Font("Gabriola", 12F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(118)))));
            this.back_btn.Location = new System.Drawing.Point(701, 376);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(87, 39);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(682, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // артикулDataGridViewTextBoxColumn
            // 
            this.артикулDataGridViewTextBoxColumn.DataPropertyName = "Артикул";
            this.артикулDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.артикулDataGridViewTextBoxColumn.Name = "артикулDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            // 
            // продуктыBindingSource
            // 
            this.продуктыBindingSource.DataMember = "Продукты";
            this.продуктыBindingSource.DataSource = this.wsdemo10DataSet;
            // 
            // wsdemo10DataSet
            // 
            this.wsdemo10DataSet.DataSetName = "wsdemo10DataSet";
            this.wsdemo10DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продуктBindingSource
            // 
            this.продуктBindingSource.DataMember = "Продукт";
            this.продуктBindingSource.DataSource = this.wsdemo10DataSet;
            // 
            // продуктTableAdapter
            // 
            this.продуктTableAdapter.ClearBeforeFill = true;
            // 
            // продуктыTableAdapter
            // 
            this.продуктыTableAdapter.ClearBeforeFill = true;
            // 
            // ImageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.izmenit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о продукции";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wsdemo10DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продуктBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private wsdemo10DataSet wsdemo10DataSet;
        private System.Windows.Forms.BindingSource продуктBindingSource;
        private wsdemo10DataSetTableAdapters.ПродуктTableAdapter продуктTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикулDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource продуктыBindingSource;
        private wsdemo10DataSetTableAdapters.ПродуктыTableAdapter продуктыTableAdapter;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button izmenit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}