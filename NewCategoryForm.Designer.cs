namespace Store
{
    partial class NewCategoryForm
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
            this.buttonApply = new DarkUI.Controls.DarkButton();
            this.buttonCancel = new DarkUI.Controls.DarkButton();
            this.nameTextBox = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.categoriesPanel = new DarkUI.Controls.DarkSectionPanel();
            this.categoriesListView = new DarkUI.Controls.DarkListView();
            this.categoriesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(194, 96);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.buttonApply.Size = new System.Drawing.Size(120, 36);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Подтвердить";
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(194, 149);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.buttonCancel.Size = new System.Drawing.Size(120, 36);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.nameTextBox.Location = new System.Drawing.Point(194, 54);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 29);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(191, 23);
            this.darkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(102, 24);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "Название:";
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.Controls.Add(this.categoriesListView);
            this.categoriesPanel.Location = new System.Drawing.Point(8, 8);
            this.categoriesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.SectionHeader = "Родительская категория";
            this.categoriesPanel.Size = new System.Drawing.Size(179, 223);
            this.categoriesPanel.TabIndex = 5;
            // 
            // categoriesListView
            // 
            this.categoriesListView.Location = new System.Drawing.Point(3, 27);
            this.categoriesListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoriesListView.Name = "categoriesListView";
            this.categoriesListView.Size = new System.Drawing.Size(174, 194);
            this.categoriesListView.TabIndex = 0;
            this.categoriesListView.Text = "darkListView1";
            this.categoriesListView.SelectedIndicesChanged += new System.EventHandler(this.categoriesListView_SelectedIndicesChanged);
            // 
            // NewCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 238);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.categoriesPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(342, 277);
            this.MinimumSize = new System.Drawing.Size(342, 277);
            this.Name = "NewCategoryForm";
            this.Text = "Новая категория";
            this.categoriesPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton buttonApply;
        private DarkUI.Controls.DarkButton buttonCancel;
        private DarkUI.Controls.DarkTextBox nameTextBox;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkSectionPanel categoriesPanel;
        private DarkUI.Controls.DarkListView categoriesListView;
    }
}