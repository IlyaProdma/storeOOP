using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;
using System.Drawing.Imaging;

namespace Store
{
    public partial class RedactProductInfo : DarkForm
    {
        private Product product;
        private string imagePath;
        private string newImagePath;
        public RedactProductInfo(Product product, string imagePath)
        {
            InitializeComponent();
            this.product = product;
            this.imagePath = imagePath;
            newImagePath = "";
            nameTextBox.Text = product.Name;
            codeTextBox.Text = product.VendorCode;
            priceRetailTextBox.Text = product.PriceRetail.ToString();
            priceWholesaleTextBox.Text = product.PriceWholesale.ToString();
            quantityTextBox.Text = product.QuantityInStock.ToString();
            massTextBox.Text = product.Mass.ToString();
            manufacturerTextBox.Text = product.Manufacturer;
            placeProductionTextBox.Text = product.PlaceOfProduction;
            seriesProductionTextBox.Text = product.ProductionSeries;
            productPictureBox.Image = new Bitmap(imagePath);
            applyButton.Click += applyButton_Click;
            fillCategoryComboBox();
        }

        public RedactProductInfo()
        {
            InitializeComponent();
            newImagePath = "";
            applyButton.Click += addNewProduct_Click;
            deleteButton.Visible = false;
            categoryLabel.Visible = true;
            categoryComboBox.Visible = true;
            subcategoryLabel.Visible = true;
            subcategoryComboBox.Visible = true;
            fillCategoryComboBox();
        }

        private void fillCategoryComboBox()
        {
            List<Category> categories = Utils.readAllCategories();
            categoryComboBox.Items.Clear();
            foreach (var cat in categories)
            {
                categoryComboBox.Items.Add(cat.Name);
            }
        }

        private void priceRetailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(priceRetailTextBox.Text, "(?:^[0-9]+.[0-9]+$)|(?:^[1-9][0-9]*$)").Success)
            {
                    if ((priceRetailTextBox.Text.Length > 1
                        && priceRetailTextBox.Text[priceRetailTextBox.Text.Length - 1] == '.'
                        && priceRetailTextBox.Text[priceRetailTextBox.Text.Length - 2] == '.')
                        || (priceRetailTextBox.Text.Length > 0 
                            && !char.IsDigit(priceRetailTextBox.Text[priceRetailTextBox.Text.Length-1]))
                            && priceRetailTextBox.Text[priceRetailTextBox.Text.Length - 1] != '.')
                    {
                            priceRetailTextBox.Text = priceRetailTextBox.Text.Remove(priceRetailTextBox.Text.Length - 1);
                    }
            }
        }

        private void priceWholesaleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(priceWholesaleTextBox.Text, "(?:^[0-9]+.[0-9]+$)|(?:^[1-9][0-9]*$)").Success)
            {
                if ((priceWholesaleTextBox.Text.Length > 1
                    && priceWholesaleTextBox.Text[priceWholesaleTextBox.Text.Length - 1] == '.'
                    && priceWholesaleTextBox.Text[priceWholesaleTextBox.Text.Length - 2] == '.')
                    || (priceWholesaleTextBox.Text.Length > 0
                        && !char.IsDigit(priceWholesaleTextBox.Text[priceWholesaleTextBox.Text.Length - 1]))
                        && priceWholesaleTextBox.Text[priceWholesaleTextBox.Text.Length - 1] != '.')
                {
                    priceWholesaleTextBox.Text = priceWholesaleTextBox.Text.Remove(priceWholesaleTextBox.Text.Length - 1);
                }
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(quantityTextBox.Text, "(?:^[0-9]+$)").Success)
            {
                if (quantityTextBox.Text.Length > 0)
                {
                    quantityTextBox.Text = quantityTextBox.Text.Remove(quantityTextBox.Text.Length - 1);
                }
            }
        }

        private void massTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(massTextBox.Text, "(?:^[0-9]+.[0-9]+$)|(?:^[1-9][0-9]*$)").Success)
            {
                if ((massTextBox.Text.Length > 1
                    && massTextBox.Text[massTextBox.Text.Length - 1] == '.'
                    && massTextBox.Text[massTextBox.Text.Length - 2] == '.')
                    || (massTextBox.Text.Length > 0
                        && !char.IsDigit(massTextBox.Text[massTextBox.Text.Length - 1]))
                        && massTextBox.Text[massTextBox.Text.Length - 1] != '.')
                {
                    massTextBox.Text = massTextBox.Text.Remove(massTextBox.Text.Length - 1);
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && codeTextBox.Text.Length > 0 && priceRetailTextBox.Text.Length > 0
                && priceWholesaleTextBox.Text.Length > 0 && quantityTextBox.Text.Length > 0 && massTextBox.Text.Length > 0
                && manufacturerTextBox.Text.Length > 0 && placeProductionTextBox.Text.Length > 0 && seriesProductionTextBox.Text.Length > 0)
            {
                List<Product> allProducts = Utils.readAllProducts();
                if (this.product.Name.Equals(nameTextBox.Text) || allProducts.Find(p => p.Name.Equals(nameTextBox.Name)) == null)
                {
                    if (this.product.VendorCode.Equals(codeTextBox.Text) 
                        || allProducts.Find(p => p.VendorCode.Equals(codeTextBox.Text)) == null)
                    {
                        for (int i = 0; i < allProducts.Count; ++i)
                        {
                            if (allProducts[i].VendorCode.Equals(this.product.VendorCode))
                            {
                                updateValues(allProducts.ElementAt(i));
                                Utils.writeProducts(allProducts);
                                List<JsonImage> images = Utils.readAllImages();
                                if (newImagePath != "")
                                    images.Find(im => im.VendorCode.Equals(product.VendorCode)).Image = newImagePath;
                                images.Find(im => im.VendorCode.Equals(product.VendorCode)).VendorCode = allProducts[i].VendorCode;
                                Utils.writeImages(images);
                                Close();
                            }
                        }
                    }
                }
            }
            else
            {
                DarkMessageBox.ShowError("Заполните все поля!", "Ошибка");
            }
        }

        private void updateValues(Product p)
        {
            p.Name = nameTextBox.Text;
            p.VendorCode = codeTextBox.Text;
            p.Manufacturer = manufacturerTextBox.Text;
            p.PlaceOfProduction = placeProductionTextBox.Text;
            p.ProductionSeries = seriesProductionTextBox.Text;
            double d;
            if (double.TryParse(priceRetailTextBox.Text, out d))
            {
                p.PriceRetail = d;
            }
            if (double.TryParse(priceWholesaleTextBox.Text, out d))
            {
                p.PriceWholesale = d;
            }
            if (uint.TryParse(quantityTextBox.Text, out uint i))
            {
                p.QuantityInStock = i;
            }
            if (double.TryParse(massTextBox.Text, out d))
            {
                p.Mass = d;
            }
            if (newImagePath != "")
            {
                productPictureBox.Image.Save(newImagePath);
            }
        }

        private void uploadNewPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int index = Directory.GetFiles("images").Length+1;
                newImagePath = $"images/{index}.jpg";
                productPictureBox.Image = new Bitmap(openFile.FileName);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            List<Product> allProducts = Utils.readAllProducts();
            allProducts.Remove(allProducts.Find(p => p.VendorCode.Equals(product.VendorCode)));
            Utils.writeProducts(allProducts);
            List<JsonImage> allImages = Utils.readAllImages();
            allImages.Remove(allImages.Find(im => im.VendorCode.Equals(product.VendorCode)));
            Utils.writeImages(allImages);
            List<Customer> allCustomers = Utils.readAllCustomers();
            foreach (var customer in allCustomers)
            {
                customer.Cart.Remove(customer.Cart.Find(p => p.VendorCode.Equals(product.VendorCode)));
                customer.Favorites.Remove(customer.Favorites.Find(p => p.VendorCode.Equals(product.VendorCode)));
            }
            Utils.writeCustomers(allCustomers);
            DarkMessageBox.ShowInformation($"Товар \"{product.Name}\" успешно удален.", "Успешно");
            Close();
        }

        private void addNewProduct_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length > 0 && codeTextBox.Text.Length > 0 && priceRetailTextBox.Text.Length > 0
                && priceWholesaleTextBox.Text.Length > 0 && quantityTextBox.Text.Length > 0 && massTextBox.Text.Length > 0
                && manufacturerTextBox.Text.Length > 0 && placeProductionTextBox.Text.Length > 0 && seriesProductionTextBox.Text.Length > 0)
            {
                List<Product> allProducts = Utils.readAllProducts();
                if (allProducts.Find(p => p.Name.Equals(nameTextBox.Text)) != null)
                {
                    DarkMessageBox.ShowError("Продукт с таким названием уже есть!", "Ошибка");
                }
                else
                {
                    if (allProducts.Find(p => p.VendorCode.Equals(codeTextBox.Text)) != null)
                    {
                        DarkMessageBox.ShowError("Продукт с таким артикулом уже есть!", "Ошибка");
                    }
                    else
                    {
                        if (newImagePath.Equals(""))
                        {
                            DarkMessageBox.ShowError("Загрузите фото товара!", "Ошибка");
                        }
                        else
                        {
                            string category = "";
                            string subcategory = "";
                            if (categoryComboBox.SelectedItem != null)
                            {
                                category = categoryComboBox.SelectedItem.ToString();
                                if (subcategoryComboBox.SelectedItem != null)
                                {
                                    subcategory = subcategoryComboBox.SelectedItem.ToString();
                                }
                            }
                            addNewProduct(allProducts, category, subcategory);
                        }
                    }
                }
            }
            else
            {
                DarkMessageBox.ShowError("Заполните все поля!", "Ошибка");
            }
        }

        private void addNewProduct(List<Product> allProducts, string category, string subcategory)
        {
            allProducts.Add(new Product(name: nameTextBox.Text,
                                                        vendorCode: codeTextBox.Text,
                                                        category: category,
                                                        subcategory: subcategory,
                                                        priceRetail: double.Parse(priceRetailTextBox.Text),
                                                        priceWholesale: double.Parse(priceWholesaleTextBox.Text),
                                                        quantityInStock: uint.Parse(quantityTextBox.Text),
                                                        mass: double.Parse(massTextBox.Text),
                                                        manufacturer: manufacturerTextBox.Text,
                                                        placeOfProduction: placeProductionTextBox.Text,
                                                        productionSeries: seriesProductionTextBox.Text));
            Utils.writeProducts(allProducts);
            productPictureBox.Image.Save(newImagePath);
            List<JsonImage> images = Utils.readAllImages();
            images.Add(new JsonImage(codeTextBox.Text, newImagePath));
            Utils.writeImages(images);
            Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem != null)
            {
                Category category = Utils.readAllCategories().Find(cat => cat.Name.Equals(categoryComboBox.SelectedItem.ToString()));
                subcategoryComboBox.Items.Clear();
                foreach (var subcat in category.Subcategories)
                {
                    subcategoryComboBox.Items.Add(subcat.Name);
                }
            }
        }
    }
}
