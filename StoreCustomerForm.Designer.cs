namespace Store
{
    partial class StoreCustomerForm
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
            this.buttonFavorites = new DarkUI.Controls.DarkButton();
            this.buttonCart = new DarkUI.Controls.DarkButton();
            this.categoriesTree = new DarkUI.Controls.DarkTreeView();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.productsListView = new System.Windows.Forms.ListView();
            this.columnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRetailPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOperations = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.buttonOperations);
            this.darkSectionPanel1.Controls.Add(this.buttonFavorites);
            this.darkSectionPanel1.Controls.Add(this.buttonCart);
            this.darkSectionPanel1.Controls.Add(this.categoriesTree);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkSectionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel1.Location = new System.Drawing.Point(10, 9);
            this.darkSectionPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Категории товаров";
            this.darkSectionPanel1.Size = new System.Drawing.Size(300, 693);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // buttonFavorites
            // 
            this.buttonFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavorites.Location = new System.Drawing.Point(9, 576);
            this.buttonFavorites.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFavorites.Name = "buttonFavorites";
            this.buttonFavorites.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonFavorites.Size = new System.Drawing.Size(285, 48);
            this.buttonFavorites.TabIndex = 2;
            this.buttonFavorites.Text = "Избранное";
            this.buttonFavorites.Click += new System.EventHandler(this.buttonFavorites_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCart.Location = new System.Drawing.Point(9, 518);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonCart.Size = new System.Drawing.Size(285, 48);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "Корзина";
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // categoriesTree
            // 
            this.categoriesTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesTree.Location = new System.Drawing.Point(2, 38);
            this.categoriesTree.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoriesTree.MaxDragChange = 20;
            this.categoriesTree.Name = "categoriesTree";
            this.categoriesTree.Size = new System.Drawing.Size(298, 470);
            this.categoriesTree.TabIndex = 0;
            this.categoriesTree.Text = "Категории";
            this.categoriesTree.SelectedNodesChanged += new System.EventHandler(this.categoriesTree_SelectedNodesChanged);
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.productsListView);
            this.darkSectionPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSectionPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel2.Location = new System.Drawing.Point(310, 9);
            this.darkSectionPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Выбранная категория:";
            this.darkSectionPanel2.Size = new System.Drawing.Size(864, 692);
            this.darkSectionPanel2.TabIndex = 1;
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
            this.productsListView.Location = new System.Drawing.Point(8, 57);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(854, 631);
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
            // buttonOperations
            // 
            this.buttonOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperations.Location = new System.Drawing.Point(9, 634);
            this.buttonOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOperations.Name = "buttonOperations";
            this.buttonOperations.Padding = new System.Windows.Forms.Padding(8);
            this.buttonOperations.Size = new System.Drawing.Size(285, 48);
            this.buttonOperations.TabIndex = 3;
            this.buttonOperations.Text = "Список операций";
            this.buttonOperations.Click += new System.EventHandler(this.buttonOperations_Click);
            // 
            // StoreCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(1200, 750);
            this.Name = "StoreCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Text = "Каталог товаров";
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkTreeView categoriesTree;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkButton buttonFavorites;
        private DarkUI.Controls.DarkButton buttonCart;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader columnImage;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnRetailPrice;
        private DarkUI.Controls.DarkButton buttonOperations;
    }
}