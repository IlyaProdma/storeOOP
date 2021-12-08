namespace Store
{
    partial class StoreStaffForm
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
            this.categoriesTree = new DarkUI.Controls.DarkTreeView();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.buttonOrders = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.productsListView = new System.Windows.Forms.ListView();
            this.columnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRetailPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonNewProduct = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoriesTree
            // 
            this.categoriesTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesTree.Location = new System.Drawing.Point(1, 25);
            this.categoriesTree.MaxDragChange = 20;
            this.categoriesTree.Name = "categoriesTree";
            this.categoriesTree.Size = new System.Drawing.Size(199, 281);
            this.categoriesTree.TabIndex = 0;
            this.categoriesTree.Text = "Категории";
            this.categoriesTree.SelectedNodesChanged += new System.EventHandler(this.categoriesTree_SelectedNodesChanged);
            this.categoriesTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.categoriesTree_MouseClick);
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.buttonNewProduct);
            this.darkSectionPanel1.Controls.Add(this.buttonOrders);
            this.darkSectionPanel1.Controls.Add(this.categoriesTree);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkSectionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel1.Location = new System.Drawing.Point(7, 6);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Категории товаров";
            this.darkSectionPanel1.Size = new System.Drawing.Size(200, 450);
            this.darkSectionPanel1.TabIndex = 1;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(5, 312);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(5);
            this.buttonOrders.Size = new System.Drawing.Size(189, 52);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Заказы";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.productsListView);
            this.darkSectionPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSectionPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel2.Location = new System.Drawing.Point(207, 6);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Выбранная категория:";
            this.darkSectionPanel2.Size = new System.Drawing.Size(575, 450);
            this.darkSectionPanel2.TabIndex = 2;
            // 
            // productsListView
            // 
            this.productsListView.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.productsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnImage,
            this.columnName,
            this.columnRetailPrice});
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(5, 37);
            this.productsListView.Margin = new System.Windows.Forms.Padding(2);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(570, 411);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productsListView_MouseDoubleClick);
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
            // buttonNewProduct
            // 
            this.buttonNewProduct.Location = new System.Drawing.Point(5, 370);
            this.buttonNewProduct.Name = "buttonNewProduct";
            this.buttonNewProduct.Padding = new System.Windows.Forms.Padding(5);
            this.buttonNewProduct.Size = new System.Drawing.Size(189, 52);
            this.buttonNewProduct.TabIndex = 2;
            this.buttonNewProduct.Text = "Новый товар";
            this.buttonNewProduct.Click += new System.EventHandler(this.buttonNewProduct_Click);
            // 
            // StoreStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Name = "StoreStaffForm";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Text = "StoreStaffForm";
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkTreeView categoriesTree;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader columnImage;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnRetailPrice;
        private DarkUI.Controls.DarkButton buttonOrders;
        private DarkUI.Controls.DarkButton buttonNewProduct;
    }
}