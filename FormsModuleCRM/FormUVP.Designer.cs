
namespace FormsModuleCRM
{
    partial class FormUVP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUVP));
            this.buttonSotrudniks = new System.Windows.Forms.ComboBox();
            this.sotrudniksTNCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ws04DataSet = new FormsModuleCRM.ws04DataSet();
            this.listBoxMainTNS = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxModUVP = new System.Windows.Forms.PictureBox();
            this.pictureBoxModUSO = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonS = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sotrudniksTNCTableAdapter = new FormsModuleCRM.ws04DataSetTableAdapters.SotrudniksTNCTableAdapter();
            this.buttonTVSB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonNCHT = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonTVCHT = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonTime11 = new System.Windows.Forms.Button();
            this.buttonTime12 = new System.Windows.Forms.Button();
            this.buttonTime13 = new System.Windows.Forms.Button();
            this.buttonTime14 = new System.Windows.Forms.Button();
            this.buttonTime15 = new System.Windows.Forms.Button();
            this.buttonTime16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudniksTNCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws04DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModUVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModUSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSotrudniks
            // 
            this.buttonSotrudniks.DataSource = this.sotrudniksTNCBindingSource;
            this.buttonSotrudniks.DisplayMember = "ФИО";
            this.buttonSotrudniks.FormattingEnabled = true;
            this.buttonSotrudniks.Location = new System.Drawing.Point(506, 25);
            this.buttonSotrudniks.Name = "buttonSotrudniks";
            this.buttonSotrudniks.Size = new System.Drawing.Size(200, 26);
            this.buttonSotrudniks.TabIndex = 24;
            this.buttonSotrudniks.ValueMember = "ID";
            // 
            // sotrudniksTNCBindingSource
            // 
            this.sotrudniksTNCBindingSource.DataMember = "SotrudniksTNC";
            this.sotrudniksTNCBindingSource.DataSource = this.ws04DataSet;
            // 
            // ws04DataSet
            // 
            this.ws04DataSet.DataSetName = "ws04DataSet";
            this.ws04DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBoxMainTNS
            // 
            this.listBoxMainTNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.listBoxMainTNS.FormattingEnabled = true;
            this.listBoxMainTNS.ItemHeight = 18;
            this.listBoxMainTNS.Location = new System.Drawing.Point(731, 123);
            this.listBoxMainTNS.Name = "listBoxMainTNS";
            this.listBoxMainTNS.Size = new System.Drawing.Size(141, 418);
            this.listBoxMainTNS.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBoxModUVP);
            this.panel1.Controls.Add(this.pictureBoxModUSO);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 541);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox8
            // 
//            this.pictureBox8.Image = global::FormsModuleCRM.Properties.Resources.CRM;
            this.pictureBox8.Location = new System.Drawing.Point(25, 410);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(56, 55);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
//            this.pictureBox2.Image = global::FormsModuleCRM.Properties.Resources.Лого_ТНС;
            this.pictureBox2.Location = new System.Drawing.Point(25, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
//            this.pictureBox3.Image = global::FormsModuleCRM.Properties.Resources.Абоненты;
            this.pictureBox3.Location = new System.Drawing.Point(25, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBoxModUVP
            // 
       //     this.pictureBoxModUVP.Image = global::FormsModuleCRM.Properties.Resources.Поддержка_пользователей;
            this.pictureBoxModUVP.Location = new System.Drawing.Point(25, 356);
            this.pictureBoxModUVP.Name = "pictureBoxModUVP";
            this.pictureBoxModUVP.Size = new System.Drawing.Size(56, 48);
            this.pictureBoxModUVP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxModUVP.TabIndex = 16;
            this.pictureBoxModUVP.TabStop = false;
            this.pictureBoxModUVP.Click += new System.EventHandler(this.pictureBoxModUVP_Click);
            // 
            // pictureBoxModUSO
            // 
            this.pictureBoxModUSO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxModUSO.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.pictureBoxModUSO.Image = global::FormsModuleCRM.Properties.Resources.Управление_обрудованием;
            this.pictureBoxModUSO.Location = new System.Drawing.Point(25, 86);
            this.pictureBoxModUSO.Name = "pictureBoxModUSO";
            this.pictureBoxModUSO.Size = new System.Drawing.Size(56, 63);
            this.pictureBoxModUSO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxModUSO.TabIndex = 13;
            this.pictureBoxModUSO.TabStop = false;
            // 
            // pictureBox6
            // 
//            this.pictureBox6.Image = global::FormsModuleCRM.Properties.Resources.Биллинг;
            this.pictureBox6.Location = new System.Drawing.Point(25, 265);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
//            this.pictureBox5.Image = global::FormsModuleCRM.Properties.Resources.Активы;
            this.pictureBox5.Location = new System.Drawing.Point(25, 155);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 104);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.panel2.Controls.Add(this.buttonS);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonSotrudniks);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(108, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 119);
            this.panel2.TabIndex = 29;
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonS.FlatAppearance.BorderSize = 0;
            this.buttonS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonS.Location = new System.Drawing.Point(623, 86);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(141, 33);
            this.buttonS.TabIndex = 32;
            this.buttonS.Text = "События";
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФИО абонента"});
            this.comboBox1.Location = new System.Drawing.Point(158, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 26);
            this.comboBox1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Заявки абонента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Выбор абонента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Поддержка пользователей";
            // 
            // pictureBox1
            // 
//            this.pictureBox1.Image = global::FormsModuleCRM.Properties.Resources.Фото_для_заглушки_при_отсутствии_фото_сотрудника;
            this.pictureBox1.Location = new System.Drawing.Point(715, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // sotrudniksTNCTableAdapter
            // 
            this.sotrudniksTNCTableAdapter.ClearBeforeFill = true;
            // 
            // buttonTVSB
            // 
            this.buttonTVSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonTVSB.FlatAppearance.BorderSize = 0;
            this.buttonTVSB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonTVSB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.buttonTVSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTVSB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTVSB.ForeColor = System.Drawing.Color.White;
            this.buttonTVSB.Location = new System.Drawing.Point(660, 243);
            this.buttonTVSB.Name = "buttonTVSB";
            this.buttonTVSB.Size = new System.Drawing.Size(65, 39);
            this.buttonTVSB.TabIndex = 30;
            this.buttonTVSB.Text = "Требует\r\nвыезда\r\n";
            this.buttonTVSB.UseVisualStyleBackColor = false;
            this.buttonTVSB.Click += new System.EventHandler(this.buttonTVSB_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(572, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "13:00 - 13:30";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonNCHT
            // 
            this.buttonNCHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonNCHT.FlatAppearance.BorderSize = 0;
            this.buttonNCHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonNCHT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.buttonNCHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNCHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNCHT.ForeColor = System.Drawing.Color.White;
            this.buttonNCHT.Location = new System.Drawing.Point(302, 156);
            this.buttonNCHT.Name = "buttonNCHT";
            this.buttonNCHT.Size = new System.Drawing.Size(65, 39);
            this.buttonNCHT.TabIndex = 30;
            this.buttonNCHT.Text = "Новая";
            this.buttonNCHT.UseVisualStyleBackColor = false;
            this.buttonNCHT.Click += new System.EventHandler(this.buttonNCHT_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(214, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 39);
            this.button4.TabIndex = 30;
            this.button4.Text = "11:30 - 12:00";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // buttonTVCHT
            // 
            this.buttonTVCHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonTVCHT.FlatAppearance.BorderSize = 0;
            this.buttonTVCHT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonTVCHT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.buttonTVCHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTVCHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTVCHT.ForeColor = System.Drawing.Color.White;
            this.buttonTVCHT.Location = new System.Drawing.Point(302, 195);
            this.buttonTVCHT.Name = "buttonTVCHT";
            this.buttonTVCHT.Size = new System.Drawing.Size(65, 39);
            this.buttonTVCHT.TabIndex = 30;
            this.buttonTVCHT.Text = "Требует\r\nвыезда\r\n";
            this.buttonTVCHT.UseVisualStyleBackColor = false;
            this.buttonTVCHT.Click += new System.EventHandler(this.buttonTVCHT_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(230)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(214, 195);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 39);
            this.button6.TabIndex = 30;
            this.button6.Text = "12:00 - 12:30";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // buttonTime11
            // 
            this.buttonTime11.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime11.Location = new System.Drawing.Point(108, 125);
            this.buttonTime11.Name = "buttonTime11";
            this.buttonTime11.Size = new System.Drawing.Size(100, 70);
            this.buttonTime11.TabIndex = 31;
            this.buttonTime11.Text = "11:00";
            this.buttonTime11.UseVisualStyleBackColor = true;
            this.buttonTime11.Click += new System.EventHandler(this.buttonTime11_Click);
            // 
            // buttonTime12
            // 
            this.buttonTime12.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime12.Location = new System.Drawing.Point(108, 195);
            this.buttonTime12.Name = "buttonTime12";
            this.buttonTime12.Size = new System.Drawing.Size(100, 70);
            this.buttonTime12.TabIndex = 32;
            this.buttonTime12.Text = "12:00";
            this.buttonTime12.UseVisualStyleBackColor = true;
            this.buttonTime12.Click += new System.EventHandler(this.buttonTime12_Click);
            // 
            // buttonTime13
            // 
            this.buttonTime13.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime13.Location = new System.Drawing.Point(108, 265);
            this.buttonTime13.Name = "buttonTime13";
            this.buttonTime13.Size = new System.Drawing.Size(100, 70);
            this.buttonTime13.TabIndex = 33;
            this.buttonTime13.Text = "13:00";
            this.buttonTime13.UseVisualStyleBackColor = true;
            this.buttonTime13.Click += new System.EventHandler(this.buttonTime13_Click);
            // 
            // buttonTime14
            // 
            this.buttonTime14.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime14.Location = new System.Drawing.Point(108, 335);
            this.buttonTime14.Name = "buttonTime14";
            this.buttonTime14.Size = new System.Drawing.Size(100, 70);
            this.buttonTime14.TabIndex = 34;
            this.buttonTime14.Text = "14:00";
            this.buttonTime14.UseVisualStyleBackColor = true;
            this.buttonTime14.Click += new System.EventHandler(this.buttonTime14_Click);
            // 
            // buttonTime15
            // 
            this.buttonTime15.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime15.Location = new System.Drawing.Point(108, 405);
            this.buttonTime15.Name = "buttonTime15";
            this.buttonTime15.Size = new System.Drawing.Size(100, 70);
            this.buttonTime15.TabIndex = 35;
            this.buttonTime15.Text = "15:00";
            this.buttonTime15.UseVisualStyleBackColor = true;
            this.buttonTime15.Click += new System.EventHandler(this.buttonTime15_Click);
            // 
            // buttonTime16
            // 
            this.buttonTime16.Font = new System.Drawing.Font("Consolas", 18F);
            this.buttonTime16.Location = new System.Drawing.Point(108, 475);
            this.buttonTime16.Name = "buttonTime16";
            this.buttonTime16.Size = new System.Drawing.Size(100, 70);
            this.buttonTime16.TabIndex = 36;
            this.buttonTime16.Text = "16:00";
            this.buttonTime16.UseVisualStyleBackColor = true;
            this.buttonTime16.Click += new System.EventHandler(this.buttonTime16_Click);
            // 
            // FormUVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonTime16);
            this.Controls.Add(this.buttonTime15);
            this.Controls.Add(this.buttonTime14);
            this.Controls.Add(this.buttonTime13);
            this.Controls.Add(this.buttonTime12);
            this.Controls.Add(this.buttonTime11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonTVCHT);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonNCHT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonTVSB);
            this.Controls.Add(this.listBoxMainTNS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormUVP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUVP";
            this.Load += new System.EventHandler(this.FormUVP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sotrudniksTNCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws04DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModUVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModUSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox buttonSotrudniks;
        private System.Windows.Forms.ListBox listBoxMainTNS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxModUVP;
        private System.Windows.Forms.PictureBox pictureBoxModUSO;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ws04DataSet ws04DataSet;
        private System.Windows.Forms.BindingSource sotrudniksTNCBindingSource;
        private ws04DataSetTableAdapters.SotrudniksTNCTableAdapter sotrudniksTNCTableAdapter;
        private System.Windows.Forms.Button buttonTVSB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonNCHT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonTVCHT;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonTime11;
        private System.Windows.Forms.Button buttonTime12;
        private System.Windows.Forms.Button buttonTime13;
        private System.Windows.Forms.Button buttonTime14;
        private System.Windows.Forms.Button buttonTime15;
        private System.Windows.Forms.Button buttonTime16;
    }
}