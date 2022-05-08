
namespace Sessia_2
{
    partial class AllOneUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllOneUser));
            this.OneAdbonts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.OneAdbonts)).BeginInit();
            this.SuspendLayout();
            // 
            // OneAdbonts
            // 
            this.OneAdbonts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OneAdbonts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneAdbonts.Location = new System.Drawing.Point(0, 0);
            this.OneAdbonts.Name = "OneAdbonts";
            this.OneAdbonts.Size = new System.Drawing.Size(1259, 134);
            this.OneAdbonts.TabIndex = 0;
            // 
            // AllOneUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 134);
            this.Controls.Add(this.OneAdbonts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllOneUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Телеком Нева Связь";
            this.Load += new System.EventHandler(this.AllOneUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OneAdbonts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView OneAdbonts;
    }
}