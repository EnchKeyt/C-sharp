
namespace OOO_Telecom_Neva_Svyaz
{
    partial class VseInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VseInfo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSerNomer = new System.Windows.Forms.TextBox();
            this.textBoxxarakteristika = new System.Windows.Forms.TextBox();
            this.buttonProverka = new System.Windows.Forms.Button();
            this.textBoxIntrfeys = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxSkorost = new System.Windows.Forms.TextBox();
            this.textBoxStandart = new System.Windows.Forms.TextBox();
            this.textBoxMesto = new System.Windows.Forms.TextBox();
            this.textBoxChastota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSerNomer
            // 
            this.textBoxSerNomer.Location = new System.Drawing.Point(165, 105);
            this.textBoxSerNomer.Name = "textBoxSerNomer";
            this.textBoxSerNomer.Size = new System.Drawing.Size(100, 20);
            this.textBoxSerNomer.TabIndex = 2;
            // 
            // textBoxxarakteristika
            // 
            this.textBoxxarakteristika.Location = new System.Drawing.Point(280, 105);
            this.textBoxxarakteristika.Name = "textBoxxarakteristika";
            this.textBoxxarakteristika.Size = new System.Drawing.Size(100, 20);
            this.textBoxxarakteristika.TabIndex = 3;
            // 
            // buttonProverka
            // 
            this.buttonProverka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.buttonProverka.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProverka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.buttonProverka.Location = new System.Drawing.Point(222, 221);
            this.buttonProverka.Name = "buttonProverka";
            this.buttonProverka.Size = new System.Drawing.Size(98, 30);
            this.buttonProverka.TabIndex = 31;
            this.buttonProverka.Text = "Проверить";
            this.buttonProverka.UseVisualStyleBackColor = false;
            this.buttonProverka.Click += new System.EventHandler(this.buttonProverka_Click);
            // 
            // textBoxIntrfeys
            // 
            this.textBoxIntrfeys.Location = new System.Drawing.Point(280, 131);
            this.textBoxIntrfeys.Name = "textBoxIntrfeys";
            this.textBoxIntrfeys.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntrfeys.TabIndex = 33;
            this.textBoxIntrfeys.Visible = false;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(165, 131);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 32;
            this.textBoxPort.Visible = false;
            // 
            // textBoxSkorost
            // 
            this.textBoxSkorost.Location = new System.Drawing.Point(280, 157);
            this.textBoxSkorost.Name = "textBoxSkorost";
            this.textBoxSkorost.Size = new System.Drawing.Size(100, 20);
            this.textBoxSkorost.TabIndex = 35;
            this.textBoxSkorost.Visible = false;
            // 
            // textBoxStandart
            // 
            this.textBoxStandart.Location = new System.Drawing.Point(165, 157);
            this.textBoxStandart.Name = "textBoxStandart";
            this.textBoxStandart.Size = new System.Drawing.Size(100, 20);
            this.textBoxStandart.TabIndex = 34;
            this.textBoxStandart.Visible = false;
            // 
            // textBoxMesto
            // 
            this.textBoxMesto.Location = new System.Drawing.Point(280, 183);
            this.textBoxMesto.Name = "textBoxMesto";
            this.textBoxMesto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesto.TabIndex = 37;
            this.textBoxMesto.Visible = false;
            // 
            // textBoxChastota
            // 
            this.textBoxChastota.Location = new System.Drawing.Point(165, 183);
            this.textBoxChastota.Name = "textBoxChastota";
            this.textBoxChastota.Size = new System.Drawing.Size(100, 20);
            this.textBoxChastota.TabIndex = 36;
            this.textBoxChastota.Visible = false;
            // 
            // VseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.textBoxMesto);
            this.Controls.Add(this.textBoxChastota);
            this.Controls.Add(this.textBoxSkorost);
            this.Controls.Add(this.textBoxStandart);
            this.Controls.Add(this.textBoxIntrfeys);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.buttonProverka);
            this.Controls.Add(this.textBoxxarakteristika);
            this.Controls.Add(this.textBoxSerNomer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VseInfo";
            this.Text = "Информация об оборудовании";
            this.Load += new System.EventHandler(this.VseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSerNomer;
        private System.Windows.Forms.TextBox textBoxxarakteristika;
        private System.Windows.Forms.Button buttonProverka;
        private System.Windows.Forms.TextBox textBoxIntrfeys;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxSkorost;
        private System.Windows.Forms.TextBox textBoxStandart;
        private System.Windows.Forms.TextBox textBoxMesto;
        private System.Windows.Forms.TextBox textBoxChastota;
    }
}