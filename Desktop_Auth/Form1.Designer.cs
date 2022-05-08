
namespace FormOne
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.LLogin = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.BAuth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TKod = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PKod = new System.Windows.Forms.PictureBox();
            this.Tim = new System.Windows.Forms.Timer(this.components);
            this.BOtm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKod)).BeginInit();
            this.SuspendLayout();
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(32, 70);
            this.LLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(51, 16);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "Номер:";
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.Location = new System.Drawing.Point(27, 95);
            this.LPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(56, 16);
            this.LPassword.TabIndex = 0;
            this.LPassword.Text = "Пароль:";
            // 
            // TLogin
            // 
            this.TLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TLogin.Location = new System.Drawing.Point(91, 70);
            this.TLogin.Margin = new System.Windows.Forms.Padding(4);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(161, 22);
            this.TLogin.TabIndex = 1;
            this.TLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TLogin_KeyDown);
            // 
            // TPassword
            // 
            this.TPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TPassword.Enabled = false;
            this.TPassword.Location = new System.Drawing.Point(91, 95);
            this.TPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TPassword.MinimumSize = new System.Drawing.Size(116, 20);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(161, 22);
            this.TPassword.TabIndex = 2;
            this.TPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TPassword_KeyDown);
            // 
            // BAuth
            // 
            this.BAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.BAuth.Enabled = false;
            this.BAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAuth.Location = new System.Drawing.Point(178, 163);
            this.BAuth.Margin = new System.Windows.Forms.Padding(4);
            this.BAuth.Name = "BAuth";
            this.BAuth.Size = new System.Drawing.Size(74, 27);
            this.BAuth.TabIndex = 3;
            this.BAuth.Text = "Войти";
            this.BAuth.UseVisualStyleBackColor = false;
            this.BAuth.Click += new System.EventHandler(this.BAuth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код:";
            // 
            // TKod
            // 
            this.TKod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TKod.Enabled = false;
            this.TKod.Location = new System.Drawing.Point(91, 120);
            this.TKod.Margin = new System.Windows.Forms.Padding(4);
            this.TKod.MinimumSize = new System.Drawing.Size(116, 20);
            this.TKod.Name = "TKod";
            this.TKod.Size = new System.Drawing.Size(116, 22);
            this.TKod.TabIndex = 2;
            this.TKod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TKod_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PKod
            // 
            this.PKod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PKod.Enabled = false;
            this.PKod.Image = ((System.Drawing.Image)(resources.GetObject("PKod.Image")));
            this.PKod.Location = new System.Drawing.Point(216, 119);
            this.PKod.Margin = new System.Windows.Forms.Padding(2);
            this.PKod.Name = "PKod";
            this.PKod.Size = new System.Drawing.Size(32, 28);
            this.PKod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PKod.TabIndex = 4;
            this.PKod.TabStop = false;
            this.PKod.Click += new System.EventHandler(this.ScrollBox_Click);
            // 
            // Tim
            // 
            this.Tim.Interval = 10000;
            // 
            // BOtm
            // 
            this.BOtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BOtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.BOtm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BOtm.Location = new System.Drawing.Point(96, 163);
            this.BOtm.Margin = new System.Windows.Forms.Padding(4);
            this.BOtm.Name = "BOtm";
            this.BOtm.Size = new System.Drawing.Size(74, 27);
            this.BOtm.TabIndex = 3;
            this.BOtm.Text = "Отмена";
            this.BOtm.UseVisualStyleBackColor = false;
            this.BOtm.Click += new System.EventHandler(this.BOtm_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 250);
            this.Controls.Add(this.PKod);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BOtm);
            this.Controls.Add(this.BAuth);
            this.Controls.Add(this.TKod);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.TLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LLogin);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(447, 427);
            this.MinimumSize = new System.Drawing.Size(321, 283);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Телеком Нева Связь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button BAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TKod;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PKod;
        private System.Windows.Forms.Timer Tim;
        private System.Windows.Forms.Button BOtm;
    }
}

