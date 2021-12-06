namespace Store
{
    partial class RedactCategoryForm
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
            this.buttonChangeName = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.newNameTextBox = new DarkUI.Controls.DarkTextBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subcategoryHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClearCat = new DarkUI.Controls.DarkButton();
            this.buttonDeleteCat = new DarkUI.Controls.DarkButton();
            this.buttonDeleteSelected = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChangeName
            // 
            this.buttonChangeName.Enabled = false;
            this.buttonChangeName.Location = new System.Drawing.Point(403, 89);
            this.buttonChangeName.Name = "buttonChangeName";
            this.buttonChangeName.Padding = new System.Windows.Forms.Padding(5);
            this.buttonChangeName.Size = new System.Drawing.Size(184, 34);
            this.buttonChangeName.TabIndex = 0;
            this.buttonChangeName.Text = "Подтвердить";
            this.buttonChangeName.Click += new System.EventHandler(this.buttonChangeName_Click);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.productsListView);
            this.darkSectionPanel1.Location = new System.Drawing.Point(12, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Товары категории";
            this.darkSectionPanel1.Size = new System.Drawing.Size(385, 426);
            this.darkSectionPanel1.TabIndex = 1;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(403, 37);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(112, 13);
            this.darkLabel1.TabIndex = 2;
            this.darkLabel1.Text = "Изменить название:";
            // 
            // newNameTextBox
            // 
            this.newNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.newNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newNameTextBox.Location = new System.Drawing.Point(406, 63);
            this.newNameTextBox.Name = "newNameTextBox";
            this.newNameTextBox.Size = new System.Drawing.Size(181, 20);
            this.newNameTextBox.TabIndex = 3;
            this.newNameTextBox.TextChanged += new System.EventHandler(this.newNameTextBox_TextChanged);
            // 
            // productsListView
            // 
            this.productsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.subcategoryHeader});
            this.productsListView.ForeColor = System.Drawing.SystemColors.Control;
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(0, 41);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(385, 381);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.SelectedIndexChanged += new System.EventHandler(this.productsListView_SelectedIndexChanged);
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Название";
            this.nameHeader.Width = 174;
            // 
            // subcategoryHeader
            // 
            this.subcategoryHeader.Text = "Подкатегория";
            this.subcategoryHeader.Width = 205;
            // 
            // buttonClearCat
            // 
            this.buttonClearCat.Enabled = false;
            this.buttonClearCat.Location = new System.Drawing.Point(403, 350);
            this.buttonClearCat.Name = "buttonClearCat";
            this.buttonClearCat.Padding = new System.Windows.Forms.Padding(5);
            this.buttonClearCat.Size = new System.Drawing.Size(184, 39);
            this.buttonClearCat.TabIndex = 4;
            this.buttonClearCat.Text = "Очистить категорию";
            this.buttonClearCat.Click += new System.EventHandler(this.buttonClearCat_Click);
            // 
            // buttonDeleteCat
            // 
            this.buttonDeleteCat.Location = new System.Drawing.Point(403, 395);
            this.buttonDeleteCat.Name = "buttonDeleteCat";
            this.buttonDeleteCat.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDeleteCat.Size = new System.Drawing.Size(184, 39);
            this.buttonDeleteCat.TabIndex = 5;
            this.buttonDeleteCat.Text = "Удалить категорию";
            this.buttonDeleteCat.Click += new System.EventHandler(this.buttonDeleteCat_Click);
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Enabled = false;
            this.buttonDeleteSelected.Location = new System.Drawing.Point(403, 305);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDeleteSelected.Size = new System.Drawing.Size(184, 39);
            this.buttonDeleteSelected.TabIndex = 6;
            this.buttonDeleteSelected.Text = "Убрать выделенные товары";
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // RedactCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 451);
            this.Controls.Add(this.buttonDeleteSelected);
            this.Controls.Add(this.buttonDeleteCat);
            this.Controls.Add(this.buttonClearCat);
            this.Controls.Add(this.newNameTextBox);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.buttonChangeName);
            this.Name = "RedactCategoryForm";
            this.Text = "RedactCategoryForm";
            this.darkSectionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkButton buttonChangeName;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkTextBox newNameTextBox;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader subcategoryHeader;
        private DarkUI.Controls.DarkButton buttonClearCat;
        private DarkUI.Controls.DarkButton buttonDeleteCat;
        private DarkUI.Controls.DarkButton buttonDeleteSelected;
    }
}