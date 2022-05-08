namespace TimerTick
{
    partial class Form1
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
            this.minutsText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minutsText
            // 
            this.minutsText.AutoSize = true;
            this.minutsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minutsText.Location = new System.Drawing.Point(12, 9);
            this.minutsText.Name = "minutsText";
            this.minutsText.Size = new System.Drawing.Size(159, 58);
            this.minutsText.TabIndex = 0;
            this.minutsText.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // secondText
            // 
            this.secondText.AutoSize = true;
            this.secondText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondText.Location = new System.Drawing.Point(315, 9);
            this.secondText.Name = "secondText";
            this.secondText.Size = new System.Drawing.Size(159, 58);
            this.secondText.TabIndex = 2;
            this.secondText.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 156);
            this.Controls.Add(this.secondText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutsText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label secondText;
        private System.Windows.Forms.Label minutsText;
    }
}

