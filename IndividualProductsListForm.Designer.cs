namespace Store
{
    partial class IndividualProductsListForm
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
            this.productsListView = new System.Windows.Forms.ListView();
            this.columnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRetailPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteFrom = new DarkUI.Controls.DarkButton();
            this.buttonBuy = new DarkUI.Controls.DarkButton();
            this.panelWindowName = new DarkUI.Controls.DarkSectionPanel();
            this.panelOperationsList = new DarkUI.Controls.DarkSectionPanel();
            this.operationsListView = new DarkUI.Controls.DarkListView();
            this.panelWindowName.SuspendLayout();
            this.panelOperationsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsListView
            // 
            this.productsListView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.productsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnImage,
            this.columnName,
            this.columnRetailPrice});
            this.productsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(4, 39);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(747, 655);
            this.productsListView.TabIndex = 1;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnImage
            // 
            this.columnImage.Text = "Изображение";
            this.columnImage.Width = 157;
            // 
            // columnName
            // 
            this.columnName.Text = "Название";
            this.columnName.Width = 436;
            // 
            // columnRetailPrice
            // 
            this.columnRetailPrice.Text = "Цена (розн.)";
            this.columnRetailPrice.Width = 537;
            // 
            // buttonDeleteFrom
            // 
            this.buttonDeleteFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteFrom.Location = new System.Drawing.Point(757, 105);
            this.buttonDeleteFrom.Name = "buttonDeleteFrom";
            this.buttonDeleteFrom.Padding = new System.Windows.Forms.Padding(5);
            this.buttonDeleteFrom.Size = new System.Drawing.Size(506, 60);
            this.buttonDeleteFrom.TabIndex = 2;
            this.buttonDeleteFrom.Text = "Удалить выделенное";
            this.buttonDeleteFrom.Click += new System.EventHandler(this.buttonDeleteFrom_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.Location = new System.Drawing.Point(757, 39);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Padding = new System.Windows.Forms.Padding(5);
            this.buttonBuy.Size = new System.Drawing.Size(506, 60);
            this.buttonBuy.TabIndex = 3;
            this.buttonBuy.Text = "Совершить покупку";
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // panelWindowName
            // 
            this.panelWindowName.Controls.Add(this.panelOperationsList);
            this.panelWindowName.Controls.Add(this.buttonDeleteFrom);
            this.panelWindowName.Controls.Add(this.buttonBuy);
            this.panelWindowName.Controls.Add(this.productsListView);
            this.panelWindowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWindowName.Location = new System.Drawing.Point(1, 1);
            this.panelWindowName.Name = "panelWindowName";
            this.panelWindowName.SectionHeader = null;
            this.panelWindowName.Size = new System.Drawing.Size(1592, 702);
            this.panelWindowName.TabIndex = 4;
            // 
            // panelOperationsList
            // 
            this.panelOperationsList.Controls.Add(this.operationsListView);
            this.panelOperationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOperationsList.Location = new System.Drawing.Point(757, 171);
            this.panelOperationsList.Name = "panelOperationsList";
            this.panelOperationsList.SectionHeader = "Последние покупки:";
            this.panelOperationsList.Size = new System.Drawing.Size(835, 527);
            this.panelOperationsList.TabIndex = 5;
            // 
            // operationsListView
            // 
            this.operationsListView.Location = new System.Drawing.Point(0, 42);
            this.operationsListView.Name = "operationsListView";
            this.operationsListView.Size = new System.Drawing.Size(821, 481);
            this.operationsListView.TabIndex = 0;
            this.operationsListView.Text = "Последние покупки";
            // 
            // IndividualProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 711);
            this.Controls.Add(this.panelWindowName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1600, 750);
            this.MinimumSize = new System.Drawing.Size(1600, 750);
            this.Name = "IndividualProductsListForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "IndividualProductsListForm";
            this.panelWindowName.ResumeLayout(false);
            this.panelOperationsList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader columnImage;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnRetailPrice;
        private DarkUI.Controls.DarkButton buttonDeleteFrom;
        private DarkUI.Controls.DarkButton buttonBuy;
        private DarkUI.Controls.DarkSectionPanel panelWindowName;
        private DarkUI.Controls.DarkSectionPanel panelOperationsList;
        private DarkUI.Controls.DarkListView operationsListView;
    }
}