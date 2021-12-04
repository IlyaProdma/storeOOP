namespace Store
{
    partial class ProductInfoForm
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
            this.productPicture = new System.Windows.Forms.PictureBox();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.labelProductName = new DarkUI.Controls.DarkLabel();
            this.labelProductCode = new DarkUI.Controls.DarkLabel();
            this.labelRetailPrice = new DarkUI.Controls.DarkLabel();
            this.labelWholesalePrice = new DarkUI.Controls.DarkLabel();
            this.labelQuantity = new DarkUI.Controls.DarkLabel();
            this.labelMass = new DarkUI.Controls.DarkLabel();
            this.labelManufacturer = new DarkUI.Controls.DarkLabel();
            this.labelProductionPlace = new DarkUI.Controls.DarkLabel();
            this.labelProductionSeries = new DarkUI.Controls.DarkLabel();
            this.buttonAddToCart = new DarkUI.Controls.DarkButton();
            this.buttonReturn = new DarkUI.Controls.DarkButton();
            this.buttonAddToFavorites = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).BeginInit();
            this.darkSectionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productPicture
            // 
            this.productPicture.Location = new System.Drawing.Point(12, 12);
            this.productPicture.Name = "productPicture";
            this.productPicture.Size = new System.Drawing.Size(300, 300);
            this.productPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productPicture.TabIndex = 0;
            this.productPicture.TabStop = false;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Controls.Add(this.labelProductionSeries);
            this.darkSectionPanel1.Controls.Add(this.labelProductionPlace);
            this.darkSectionPanel1.Controls.Add(this.labelManufacturer);
            this.darkSectionPanel1.Controls.Add(this.labelMass);
            this.darkSectionPanel1.Controls.Add(this.labelQuantity);
            this.darkSectionPanel1.Controls.Add(this.labelWholesalePrice);
            this.darkSectionPanel1.Controls.Add(this.labelRetailPrice);
            this.darkSectionPanel1.Controls.Add(this.labelProductCode);
            this.darkSectionPanel1.Controls.Add(this.labelProductName);
            this.darkSectionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkSectionPanel1.Location = new System.Drawing.Point(318, 12);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "Характеристики товара";
            this.darkSectionPanel1.Size = new System.Drawing.Size(470, 300);
            this.darkSectionPanel1.TabIndex = 2;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelProductName.Location = new System.Drawing.Point(4, 35);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(87, 20);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Название:";
            // 
            // labelProductCode
            // 
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelProductCode.Location = new System.Drawing.Point(4, 58);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(76, 20);
            this.labelProductCode.TabIndex = 1;
            this.labelProductCode.Text = "Артикул:";
            // 
            // labelRetailPrice
            // 
            this.labelRetailPrice.AutoSize = true;
            this.labelRetailPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetailPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelRetailPrice.Location = new System.Drawing.Point(4, 82);
            this.labelRetailPrice.Name = "labelRetailPrice";
            this.labelRetailPrice.Size = new System.Drawing.Size(105, 20);
            this.labelRetailPrice.TabIndex = 2;
            this.labelRetailPrice.Text = "Цена (розн.):";
            // 
            // labelWholesalePrice
            // 
            this.labelWholesalePrice.AutoSize = true;
            this.labelWholesalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWholesalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelWholesalePrice.Location = new System.Drawing.Point(4, 107);
            this.labelWholesalePrice.Name = "labelWholesalePrice";
            this.labelWholesalePrice.Size = new System.Drawing.Size(97, 20);
            this.labelWholesalePrice.TabIndex = 3;
            this.labelWholesalePrice.Text = "Цена (опт.):";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelQuantity.Location = new System.Drawing.Point(4, 136);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(146, 20);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Кол-во на складе:";
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelMass.Location = new System.Drawing.Point(4, 163);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(89, 20);
            this.labelMass.TabIndex = 5;
            this.labelMass.Text = "Масса (кг):";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelManufacturer.Location = new System.Drawing.Point(4, 187);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(135, 20);
            this.labelManufacturer.TabIndex = 6;
            this.labelManufacturer.Text = "Производитель:";
            // 
            // labelProductionPlace
            // 
            this.labelProductionPlace.AutoSize = true;
            this.labelProductionPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductionPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelProductionPlace.Location = new System.Drawing.Point(4, 212);
            this.labelProductionPlace.Name = "labelProductionPlace";
            this.labelProductionPlace.Size = new System.Drawing.Size(173, 20);
            this.labelProductionPlace.TabIndex = 7;
            this.labelProductionPlace.Text = "Место производства:";
            // 
            // labelProductionSeries
            // 
            this.labelProductionSeries.AutoSize = true;
            this.labelProductionSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductionSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.labelProductionSeries.Location = new System.Drawing.Point(4, 239);
            this.labelProductionSeries.Name = "labelProductionSeries";
            this.labelProductionSeries.Size = new System.Drawing.Size(60, 20);
            this.labelProductionSeries.TabIndex = 8;
            this.labelProductionSeries.Text = "Серия:";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToCart.Location = new System.Drawing.Point(412, 318);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddToCart.Size = new System.Drawing.Size(185, 43);
            this.buttonAddToCart.TabIndex = 3;
            this.buttonAddToCart.Text = "В корзину";
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(603, 318);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Padding = new System.Windows.Forms.Padding(5);
            this.buttonReturn.Size = new System.Drawing.Size(185, 43);
            this.buttonReturn.TabIndex = 4;
            this.buttonReturn.Text = "Вернуться";
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonAddToFavorites
            // 
            this.buttonAddToFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToFavorites.Location = new System.Drawing.Point(221, 318);
            this.buttonAddToFavorites.Name = "buttonAddToFavorites";
            this.buttonAddToFavorites.Padding = new System.Windows.Forms.Padding(5);
            this.buttonAddToFavorites.Size = new System.Drawing.Size(185, 43);
            this.buttonAddToFavorites.TabIndex = 6;
            this.buttonAddToFavorites.Text = "В избранное";
            this.buttonAddToFavorites.Click += new System.EventHandler(this.buttonAddToFavorites_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.buttonAddToFavorites);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.productPicture);
            this.Name = "ProductInfoForm";
            this.Text = "ProductInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.productPicture)).EndInit();
            this.darkSectionPanel1.ResumeLayout(false);
            this.darkSectionPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox productPicture;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private DarkUI.Controls.DarkLabel labelProductionSeries;
        private DarkUI.Controls.DarkLabel labelProductionPlace;
        private DarkUI.Controls.DarkLabel labelManufacturer;
        private DarkUI.Controls.DarkLabel labelMass;
        private DarkUI.Controls.DarkLabel labelQuantity;
        private DarkUI.Controls.DarkLabel labelWholesalePrice;
        private DarkUI.Controls.DarkLabel labelRetailPrice;
        private DarkUI.Controls.DarkLabel labelProductCode;
        private DarkUI.Controls.DarkLabel labelProductName;
        private DarkUI.Controls.DarkButton buttonAddToCart;
        private DarkUI.Controls.DarkButton buttonReturn;
        private DarkUI.Controls.DarkButton buttonAddToFavorites;
    }
}