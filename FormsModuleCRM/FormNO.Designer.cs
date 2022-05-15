
namespace FormsModuleCRM
{
    partial class FormNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNO));
            this.setiDostupaTableAdapter = new FormsModuleCRM.ws04DataSetKSTableAdapters.SetiDostupaTableAdapter();
            this.abonentskoeOborudovanieTableAdapter = new FormsModuleCRM.ws04DataSetKSTableAdapters.AbonentskoeOborudovanieTableAdapter();
            this.abonentskoeOborudovanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ws04DataSetKS = new FormsModuleCRM.ws04DataSetKS();
            this.comboBoxA = new System.Windows.Forms.ComboBox();
            this.setiDostupaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSD = new System.Windows.Forms.ComboBox();
            this.magistralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxMS = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.magistralTableAdapter = new FormsModuleCRM.ws04DataSetKSTableAdapters.MagistralTableAdapter();
            this.panelTopMenuLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.abonentskoeOborudovanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws04DataSetKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setiDostupaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magistralBindingSource)).BeginInit();
            this.panelLeftMenu.SuspendLayout();
            this.panelTopMenuLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // setiDostupaTableAdapter
            // 
            this.setiDostupaTableAdapter.ClearBeforeFill = true;
            // 
            // abonentskoeOborudovanieTableAdapter
            // 
            this.abonentskoeOborudovanieTableAdapter.ClearBeforeFill = true;
            // 
            // abonentskoeOborudovanieBindingSource
            // 
            this.abonentskoeOborudovanieBindingSource.DataMember = "AbonentskoeOborudovanie";
            this.abonentskoeOborudovanieBindingSource.DataSource = this.ws04DataSetKS;
            // 
            // ws04DataSetKS
            // 
            this.ws04DataSetKS.DataSetName = "ws04DataSetKS";
            this.ws04DataSetKS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxA
            // 
            this.comboBoxA.DataSource = this.abonentskoeOborudovanieBindingSource;
            this.comboBoxA.DisplayMember = "Наименование";
            this.comboBoxA.FormattingEnabled = true;
            this.comboBoxA.Location = new System.Drawing.Point(773, 147);
            this.comboBoxA.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxA.Name = "comboBoxA";
            this.comboBoxA.Size = new System.Drawing.Size(276, 26);
            this.comboBoxA.TabIndex = 9;
            this.comboBoxA.ValueMember = "ID";
            // 
            // setiDostupaBindingSource
            // 
            this.setiDostupaBindingSource.DataMember = "SetiDostupa";
            this.setiDostupaBindingSource.DataSource = this.ws04DataSetKS;
            // 
            // comboBoxSD
            // 
            this.comboBoxSD.DataSource = this.setiDostupaBindingSource;
            this.comboBoxSD.DisplayMember = "Name";
            this.comboBoxSD.FormattingEnabled = true;
            this.comboBoxSD.Location = new System.Drawing.Point(488, 147);
            this.comboBoxSD.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSD.Name = "comboBoxSD";
            this.comboBoxSD.Size = new System.Drawing.Size(276, 26);
            this.comboBoxSD.TabIndex = 8;
            this.comboBoxSD.ValueMember = "ID";
            // 
            // magistralBindingSource
            // 
            this.magistralBindingSource.DataMember = "Magistral";
            this.magistralBindingSource.DataSource = this.ws04DataSetKS;
            // 
            // comboBoxMS
            // 
            this.comboBoxMS.DataSource = this.magistralBindingSource;
            this.comboBoxMS.DisplayMember = "Название";
            this.comboBoxMS.FormattingEnabled = true;
            this.comboBoxMS.Location = new System.Drawing.Point(203, 147);
            this.comboBoxMS.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMS.Name = "comboBoxMS";
            this.comboBoxMS.Size = new System.Drawing.Size(276, 26);
            this.comboBoxMS.TabIndex = 7;
            this.comboBoxMS.ValueMember = "ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Consolas", 14F);
            this.buttonDelete.Location = new System.Drawing.Point(3, 210);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 46);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 14F);
            this.buttonAdd.Location = new System.Drawing.Point(4, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 46);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Consolas", 14F);
            this.buttonFilter.Location = new System.Drawing.Point(3, 106);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(172, 46);
            this.buttonFilter.TabIndex = 7;
            this.buttonFilter.Text = "Фильтрация";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.Font = new System.Drawing.Font("Consolas", 14F);
            this.buttonSort.Location = new System.Drawing.Point(3, 54);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(172, 46);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Сортировка";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Consolas", 14F);
            this.buttonSearch.Location = new System.Drawing.Point(4, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(172, 46);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(250)))));
            this.panelLeftMenu.Controls.Add(this.buttonDelete);
            this.panelLeftMenu.Controls.Add(this.buttonAdd);
            this.panelLeftMenu.Controls.Add(this.buttonFilter);
            this.panelLeftMenu.Controls.Add(this.buttonSort);
            this.panelLeftMenu.Controls.Add(this.buttonSearch);
            this.panelLeftMenu.Location = new System.Drawing.Point(16, 147);
            this.panelLeftMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(179, 457);
            this.panelLeftMenu.TabIndex = 6;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold);
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(345, 34);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(504, 47);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Настройка оборудования";
            // 
            // magistralTableAdapter
            // 
            this.magistralTableAdapter.ClearBeforeFill = true;
            // 
            // panelTopMenuLogo
            // 
            this.panelTopMenuLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(103)))), ((int)(((byte)(247)))));
            this.panelTopMenuLogo.Controls.Add(this.labelLogo);
            this.panelTopMenuLogo.Location = new System.Drawing.Point(16, 19);
            this.panelTopMenuLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelTopMenuLogo.Name = "panelTopMenuLogo";
            this.panelTopMenuLogo.Size = new System.Drawing.Size(1035, 119);
            this.panelTopMenuLogo.TabIndex = 5;
            // 
            // FormNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.comboBoxA);
            this.Controls.Add(this.comboBoxSD);
            this.Controls.Add(this.comboBoxMS);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelTopMenuLogo);
            this.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка оборудования";
            this.Load += new System.EventHandler(this.FormNO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonentskoeOborudovanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ws04DataSetKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setiDostupaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magistralBindingSource)).EndInit();
            this.panelLeftMenu.ResumeLayout(false);
            this.panelTopMenuLogo.ResumeLayout(false);
            this.panelTopMenuLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ws04DataSetKSTableAdapters.SetiDostupaTableAdapter setiDostupaTableAdapter;
        private ws04DataSetKSTableAdapters.AbonentskoeOborudovanieTableAdapter abonentskoeOborudovanieTableAdapter;
        private System.Windows.Forms.BindingSource abonentskoeOborudovanieBindingSource;
        private ws04DataSetKS ws04DataSetKS;
        private System.Windows.Forms.ComboBox comboBoxA;
        private System.Windows.Forms.BindingSource setiDostupaBindingSource;
        private System.Windows.Forms.ComboBox comboBoxSD;
        private System.Windows.Forms.BindingSource magistralBindingSource;
        private System.Windows.Forms.ComboBox comboBoxMS;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Label labelLogo;
        private ws04DataSetKSTableAdapters.MagistralTableAdapter magistralTableAdapter;
        private System.Windows.Forms.Panel panelTopMenuLogo;
    }
}