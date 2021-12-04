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
            this.darkSectionPanel1.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.buttonFavorites);
            this.darkSectionPanel1.Controls.Add(this.buttonCart);
            this.darkSectionPanel1.Controls.Add(this.categoriesTree);
            this.darkSectionPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkSectionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel1.Location = new System.Drawing.Point(7, 6);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Категории товаров";
            this.darkSectionPanel1.Size = new System.Drawing.Size(200, 450);
            this.darkSectionPanel1.TabIndex = 0;
            // 
            // buttonFavorites
            // 
            this.buttonFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFavorites.Location = new System.Drawing.Point(4, 398);
            this.buttonFavorites.Name = "buttonFavorites";
            this.buttonFavorites.Padding = new System.Windows.Forms.Padding(5);
            this.buttonFavorites.Size = new System.Drawing.Size(190, 31);
            this.buttonFavorites.TabIndex = 2;
            this.buttonFavorites.Text = "Избранное";
            // 
            // buttonCart
            // 
            this.buttonCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCart.Location = new System.Drawing.Point(4, 361);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Padding = new System.Windows.Forms.Padding(5);
            this.buttonCart.Size = new System.Drawing.Size(190, 31);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "Корзина";
            // 
            // categoriesTree
            // 
            this.categoriesTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesTree.Location = new System.Drawing.Point(1, 25);
            this.categoriesTree.MaxDragChange = 20;
            this.categoriesTree.Name = "categoriesTree";
            this.categoriesTree.Size = new System.Drawing.Size(199, 338);
            this.categoriesTree.TabIndex = 0;
            this.categoriesTree.Text = "Категории";
            this.categoriesTree.SelectedNodesChanged += new System.EventHandler(this.categoriesTree_SelectedNodesChanged);
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
            // StoreCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(789, 462);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.darkSectionPanel1);
            this.MaximumSize = new System.Drawing.Size(805, 501);
            this.MinimumSize = new System.Drawing.Size(805, 501);
            this.Name = "StoreCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Text = "StoreCustomerForm";
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
    }
}