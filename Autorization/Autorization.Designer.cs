
namespace Autorization
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.LblNumber = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.LblLogotip = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PicUpdate = new System.Windows.Forms.PictureBox();
            this.DopFon = new System.Windows.Forms.Panel();
            this.Time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).BeginInit();
            this.DopFon.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtCode.Location = new System.Drawing.Point(215, 234);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.ReadOnly = true;
            this.TxtCode.Size = new System.Drawing.Size(174, 26);
            this.TxtCode.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPass.Location = new System.Drawing.Point(215, 189);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.ReadOnly = true;
            this.TxtPass.Size = new System.Drawing.Size(223, 26);
            this.TxtPass.TabIndex = 0;
            this.TxtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPass_KeyDown);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtNumber.Location = new System.Drawing.Point(215, 146);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(223, 26);
            this.TxtNumber.TabIndex = 0;
            this.TxtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumber_KeyDown);
            // 
            // LblNumber
            // 
            this.LblNumber.AutoSize = true;
            this.LblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNumber.Location = new System.Drawing.Point(146, 149);
            this.LblNumber.Name = "LblNumber";
            this.LblNumber.Size = new System.Drawing.Size(63, 20);
            this.LblNumber.TabIndex = 1;
            this.LblNumber.Text = "Номер:";
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPass.Location = new System.Drawing.Point(138, 192);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(71, 20);
            this.LblPass.TabIndex = 1;
            this.LblPass.Text = "Пароль:";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCode.Location = new System.Drawing.Point(157, 237);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(43, 20);
            this.LblCode.TabIndex = 1;
            this.LblCode.Text = "Код:";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(206, 307);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 35);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(352, 307);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(86, 35);
            this.Login.TabIndex = 2;
            this.Login.Text = "Вход";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LblLogotip
            // 
            this.LblLogotip.AutoSize = true;
            this.LblLogotip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLogotip.Location = new System.Drawing.Point(43, 44);
            this.LblLogotip.Name = "LblLogotip";
            this.LblLogotip.Size = new System.Drawing.Size(279, 31);
            this.LblLogotip.TabIndex = 1;
            this.LblLogotip.Text = "Телеком Нева Связь";
            // 
            // PicLogo
            // 
            this.PicLogo.Location = new System.Drawing.Point(551, -2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(184, 154);
            this.PicLogo.TabIndex = 3;
            this.PicLogo.TabStop = false;
            // 
            // PicUpdate
            // 
            this.PicUpdate.Location = new System.Drawing.Point(406, 234);
            this.PicUpdate.Name = "PicUpdate";
            this.PicUpdate.Size = new System.Drawing.Size(32, 26);
            this.PicUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicUpdate.TabIndex = 4;
            this.PicUpdate.TabStop = false;
            this.PicUpdate.Click += new System.EventHandler(this.PicUpdate_Click);
            // 
            // DopFon
            // 
            this.DopFon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.DopFon.Controls.Add(this.LblLogotip);
            this.DopFon.Location = new System.Drawing.Point(-1, -2);
            this.DopFon.Name = "DopFon";
            this.DopFon.Size = new System.Drawing.Size(553, 130);
            this.DopFon.TabIndex = 5;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.PicUpdate);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblNumber);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.DopFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUpdate)).EndInit();
            this.DopFon.ResumeLayout(false);
            this.DopFon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label LblNumber;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label LblLogotip;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox PicUpdate;
        private System.Windows.Forms.Panel DopFon;
        private System.Windows.Forms.Timer Time;
    }
}

