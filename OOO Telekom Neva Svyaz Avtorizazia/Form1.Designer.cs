
namespace OOO_Telekom_Neva_Svyaz_Avtorizazia
{
    partial class Avtorizazia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorizazia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamber = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelKod1 = new System.Windows.Forms.Label();
            this.textBoxNamber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxKod1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Otmena = new System.Windows.Forms.Button();
            this.Vxod = new System.Windows.Forms.Button();
            this.ws02DataSet = new OOO_Telekom_Neva_Svyaz_Avtorizazia.ws02DataSet();
            this.avtorizaziaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avtorizaziaTableAdapter = new OOO_Telekom_Neva_Svyaz_Avtorizazia.ws02DataSetTableAdapters.AvtorizaziaTableAdapter();
            this.textBoxKod2 = new System.Windows.Forms.TextBox();
            this.Vrem_kod = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorizaziaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Телеком Нева Связь";
            // 
            // labelNamber
            // 
            this.labelNamber.AutoSize = true;
            this.labelNamber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamber.Location = new System.Drawing.Point(157, 107);
            this.labelNamber.Name = "labelNamber";
            this.labelNamber.Size = new System.Drawing.Size(61, 18);
            this.labelNamber.TabIndex = 2;
            this.labelNamber.Text = "Номер";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(157, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 18);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Пароль";
            this.labelPassword.Visible = false;
            // 
            // labelKod1
            // 
            this.labelKod1.AutoSize = true;
            this.labelKod1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKod1.Location = new System.Drawing.Point(157, 162);
            this.labelKod1.Name = "labelKod1";
            this.labelKod1.Size = new System.Drawing.Size(39, 18);
            this.labelKod1.TabIndex = 4;
            this.labelKod1.Text = "Код";
            this.labelKod1.Visible = false;
            // 
            // textBoxNamber
            // 
            this.textBoxNamber.Location = new System.Drawing.Point(243, 108);
            this.textBoxNamber.Multiline = true;
            this.textBoxNamber.Name = "textBoxNamber";
            this.textBoxNamber.Size = new System.Drawing.Size(180, 23);
            this.textBoxNamber.TabIndex = 5;
            this.textBoxNamber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNamber_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(243, 137);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 20);
            this.textBoxPassword.TabIndex = 6;
            this.textBoxPassword.Visible = false;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxKod1
            // 
            this.textBoxKod1.Location = new System.Drawing.Point(243, 163);
            this.textBoxKod1.Multiline = true;
            this.textBoxKod1.Name = "textBoxKod1";
            this.textBoxKod1.Size = new System.Drawing.Size(141, 20);
            this.textBoxKod1.TabIndex = 7;
            this.textBoxKod1.Visible = false;
            this.textBoxKod1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKod1_KeyDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(390, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Otmena
            // 
            this.Otmena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.Otmena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Otmena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.Otmena.Location = new System.Drawing.Point(243, 220);
            this.Otmena.Name = "Otmena";
            this.Otmena.Size = new System.Drawing.Size(75, 28);
            this.Otmena.TabIndex = 9;
            this.Otmena.Text = "Отмена";
            this.Otmena.UseVisualStyleBackColor = false;
            this.Otmena.Click += new System.EventHandler(this.Otmena_Click);
            // 
            // Vxod
            // 
            this.Vxod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.Vxod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Vxod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.Vxod.Location = new System.Drawing.Point(348, 220);
            this.Vxod.Name = "Vxod";
            this.Vxod.Size = new System.Drawing.Size(75, 28);
            this.Vxod.TabIndex = 10;
            this.Vxod.Text = "Вход";
            this.Vxod.UseVisualStyleBackColor = false;
            this.Vxod.Visible = false;
            this.Vxod.Click += new System.EventHandler(this.Vxod_Click);
            // 
            // ws02DataSet
            // 
            this.ws02DataSet.DataSetName = "ws02DataSet";
            this.ws02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avtorizaziaBindingSource
            // 
            this.avtorizaziaBindingSource.DataMember = "Avtorizazia";
            this.avtorizaziaBindingSource.DataSource = this.ws02DataSet;
            // 
            // avtorizaziaTableAdapter
            // 
            this.avtorizaziaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxKod2
            // 
            this.textBoxKod2.Location = new System.Drawing.Point(474, 163);
            this.textBoxKod2.Name = "textBoxKod2";
            this.textBoxKod2.Size = new System.Drawing.Size(81, 20);
            this.textBoxKod2.TabIndex = 11;
            this.textBoxKod2.Visible = false;
            // 
            // Vrem_kod
            // 
            this.Vrem_kod.Interval = 10000;
            this.Vrem_kod.Tick += new System.EventHandler(this.Vrem_kod_Tick);
            // 
            // Avtorizazia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 345);
            this.Controls.Add(this.textBoxKod2);
            this.Controls.Add(this.Vxod);
            this.Controls.Add(this.Otmena);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxKod1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNamber);
            this.Controls.Add(this.labelKod1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelNamber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Avtorizazia";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorizazia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avtorizaziaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamber;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelKod1;
        private System.Windows.Forms.TextBox textBoxNamber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxKod1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Otmena;
        private System.Windows.Forms.Button Vxod;
        private ws02DataSet ws02DataSet;
        private System.Windows.Forms.BindingSource avtorizaziaBindingSource;
        private ws02DataSetTableAdapters.AvtorizaziaTableAdapter avtorizaziaTableAdapter;
        private System.Windows.Forms.TextBox textBoxKod2;
        private System.Windows.Forms.Timer Vrem_kod;
    }
}

