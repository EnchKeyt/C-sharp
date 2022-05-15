
namespace FormsModuleCRM
{
    partial class FormUSO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUSO));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemKS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNO = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRKBS = new System.Windows.Forms.ToolStripMenuItem();
            this.DevToolStripMenuItemNO = new System.Windows.Forms.ToolStripMenuItem();
            this.DevToolStripMenuItemRKBS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemKS,
            this.ToolStripMenuItemNO,
            this.ToolStripMenuItemRKBS});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1904, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip";
            // 
            // ToolStripMenuItemKS
            // 
            this.ToolStripMenuItemKS.Name = "ToolStripMenuItemKS";
            this.ToolStripMenuItemKS.Size = new System.Drawing.Size(133, 20);
            this.ToolStripMenuItemKS.Text = "Контроль состояний";
            this.ToolStripMenuItemKS.Click += new System.EventHandler(this.ToolStripMenuItemKS_Click);
            // 
            // ToolStripMenuItemNO
            // 
            this.ToolStripMenuItemNO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevToolStripMenuItemNO});
            this.ToolStripMenuItemNO.Name = "ToolStripMenuItemNO";
            this.ToolStripMenuItemNO.Size = new System.Drawing.Size(160, 20);
            this.ToolStripMenuItemNO.Text = "Настройка оборудования";
            this.ToolStripMenuItemNO.Click += new System.EventHandler(this.ToolStripMenuItemNO_Click);
            // 
            // ToolStripMenuItemRKBS
            // 
            this.ToolStripMenuItemRKBS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevToolStripMenuItemRKBS});
            this.ToolStripMenuItemRKBS.Name = "ToolStripMenuItemRKBS";
            this.ToolStripMenuItemRKBS.Size = new System.Drawing.Size(219, 20);
            this.ToolStripMenuItemRKBS.Text = "Расчет количества базовых станций";
            this.ToolStripMenuItemRKBS.Click += new System.EventHandler(this.ToolStripMenuItemRKBS_Click);
            // 
            // DevToolStripMenuItemNO
            // 
            this.DevToolStripMenuItemNO.Name = "DevToolStripMenuItemNO";
            this.DevToolStripMenuItemNO.Size = new System.Drawing.Size(189, 22);
            this.DevToolStripMenuItemNO.Text = "Я разработчик(betta)";
            this.DevToolStripMenuItemNO.Click += new System.EventHandler(this.DevToolStripMenuItemNO_Click);
            // 
            // DevToolStripMenuItemRKBS
            // 
            this.DevToolStripMenuItemRKBS.Name = "DevToolStripMenuItemRKBS";
            this.DevToolStripMenuItemRKBS.Size = new System.Drawing.Size(189, 22);
            this.DevToolStripMenuItemRKBS.Text = "Я разработчик(betta)";
            this.DevToolStripMenuItemRKBS.Click += new System.EventHandler(this.DevToolStripMenuItemRKBS_Click);
            // 
            // FormUSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.menuStripMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormUSO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление сетевым оборудованием";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUSO_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemKS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNO;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRKBS;
        private System.Windows.Forms.ToolStripMenuItem DevToolStripMenuItemNO;
        private System.Windows.Forms.ToolStripMenuItem DevToolStripMenuItemRKBS;
    }
}