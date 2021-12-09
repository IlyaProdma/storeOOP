namespace Store
{
    partial class RedactOperationsForm
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
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.usersListView = new DarkUI.Controls.DarkListView();
            this.userOperationsListView = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.statusDropdown = new DarkUI.Controls.DarkDropdownList();
            this.cancelButton = new DarkUI.Controls.DarkButton();
            this.applyButton = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.usersListView);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Список покупателей";
            this.darkSectionPanel1.Size = new System.Drawing.Size(225, 426);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // usersListView
            // 
            this.usersListView.Location = new System.Drawing.Point(4, 42);
            this.usersListView.Name = "usersListView";
            this.usersListView.Size = new System.Drawing.Size(217, 380);
            this.usersListView.TabIndex = 0;
            this.usersListView.Text = "darkListView1";
            this.usersListView.SelectedIndicesChanged += new System.EventHandler(this.usersListView_SelectedIndicesChanged);
            // 
            // userOperationsListView
            // 
            this.userOperationsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.userOperationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Date,
            this.Status});
            this.userOperationsListView.ForeColor = System.Drawing.Color.Gainsboro;
            this.userOperationsListView.HideSelection = false;
            this.userOperationsListView.Location = new System.Drawing.Point(243, 12);
            this.userOperationsListView.MultiSelect = false;
            this.userOperationsListView.Name = "userOperationsListView";
            this.userOperationsListView.Size = new System.Drawing.Size(545, 278);
            this.userOperationsListView.TabIndex = 1;
            this.userOperationsListView.UseCompatibleStateImageBehavior = false;
            this.userOperationsListView.View = System.Windows.Forms.View.Details;
            this.userOperationsListView.SelectedIndexChanged += new System.EventHandler(this.userOperationsListView_SelectedIndexChanged);
            // 
            // Product
            // 
            this.Product.Text = "Название";
            this.Product.Width = 184;
            // 
            // Date
            // 
            this.Date.Text = "Дата";
            this.Date.Width = 198;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.Width = 156;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(244, 297);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(83, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Статус заказа:";
            // 
            // statusDropdown
            // 
            this.statusDropdown.Location = new System.Drawing.Point(334, 297);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(217, 26);
            this.statusDropdown.TabIndex = 3;
            this.statusDropdown.Text = "новый статус";
            this.statusDropdown.SelectedItemChanged += new System.EventHandler(this.statusDropdown_SelectedItemChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(636, 382);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(152, 56);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Назад";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(478, 382);
            this.applyButton.Name = "applyButton";
            this.applyButton.Padding = new System.Windows.Forms.Padding(5);
            this.applyButton.Size = new System.Drawing.Size(152, 56);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "Сохранить все";
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // RedactOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.statusDropdown);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.userOperationsListView);
            this.Controls.Add(this.darkSectionPanel1);
            this.Name = "RedactOperationsForm";
            this.Text = "Список заказов";
            this.darkSectionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkListView usersListView;
        private System.Windows.Forms.ListView userOperationsListView;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkDropdownList statusDropdown;
        private DarkUI.Controls.DarkButton cancelButton;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private DarkUI.Controls.DarkButton applyButton;
    }
}