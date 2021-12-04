using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using Newtonsoft.Json;

namespace Store
{
    public partial class ProductInfoForm : DarkForm
    {
        private Product product;
        private string Login;
        public ProductInfoForm(Customer customer, Product product, string imagePath)
        {
            InitializeComponent();
            this.product = product;
            Login = customer.Login;
            productPicture.Image = new Bitmap(imagePath);
            labelProductName.Text = string.Format("Название: {0}", product.Name);
            labelProductCode.Text = string.Format("Артикул: {0}", product.VendorCode);
            labelRetailPrice.Text = string.Format("Цена (розн.): {0} рублей", product.PriceRetail);
            labelWholesalePrice.Text = string.Format("Цена(опт.): {0} рублей", product.PriceWholesale);
            labelQuantity.Text = string.Format("Кол-во на складе: {0} шт.", product.QuantityInStock);
            labelMass.Text = string.Format("Масса (кг): {0}", product.Mass);
            labelManufacturer.Text = string.Format("Производитель: {0}", product.Manufacturer);
            labelProductionPlace.Text = string.Format("Место производства: {0}", product.PlaceOfProduction);
            labelProductionSeries.Text = string.Format("Серия: {0}", product.ProductionSeries);
            if (customer.Cart.Where<Product>(p => p.VendorCode == product.VendorCode).Count() > 0)
            {
                buttonAddToCart.Text = "Удалить из корзины";
                buttonAddToCart.Click += buttonRemoveFromCart_Click;
            }
            else
            {
                buttonAddToCart.Text = "Добавить в корзину";
                buttonAddToCart.Click += buttonAddToCart_Click;
            }
            if (customer.Favorites.Where<Product>(p => p.VendorCode == product.VendorCode).Count() > 0)
            {
                buttonAddToFavorites.Text = "Удалить из избранного";
                buttonAddToFavorites.Click += buttonRemoveFromFavorites_Click;
            }
            else
            {
                buttonAddToFavorites.Text = "Добавить в избранное";
                buttonAddToFavorites.Click += buttonAddToFavorites_Click;
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            int index = customers.IndexOf(customers.Where<Customer>(cs => cs.Login == Login).ElementAt(0));
            if (customers[index].Cart.Where<Product>(p => p.VendorCode == product.VendorCode).Count() <= 0)
            {
                customers[index].Cart.Add(product);
                File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                buttonAddToCart.Text = "Удалить из корзины";
                buttonAddToCart.Click += buttonRemoveFromCart_Click;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            int index = customers.IndexOf(customers.Where<Customer>(cs => cs.Login == Login).ElementAt(0));
            var filtered = customers[index].Cart.Where<Product>(p => p.VendorCode == product.VendorCode);
            if (filtered.Count() > 0)
            {
                int cartIndex = customers[index].Cart.IndexOf(filtered.ElementAt(0));
                customers[index].Cart.RemoveAt(cartIndex);
                File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                buttonAddToCart.Text = "Добавить в корзину";
                buttonAddToCart.Click += buttonAddToCart_Click;
            }
        }

        private void buttonAddToFavorites_Click(object sender, EventArgs e)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            int index = customers.IndexOf(customers.Where<Customer>(cs => cs.Login == Login).ElementAt(0));
            if (customers[index].Favorites.Where<Product>(p => p.VendorCode == product.VendorCode).Count() <= 0)
            {
                customers[index].Favorites.Add(product);
                File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                buttonAddToFavorites.Text = "Удалить из избранного";
                buttonAddToFavorites.Click += buttonRemoveFromFavorites_Click;
            }
        }

        private void buttonRemoveFromFavorites_Click(object sender, EventArgs e)
        {
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            int index = customers.IndexOf(customers.Where<Customer>(cs => cs.Login == Login).ElementAt(0));
            var filtered = customers[index].Favorites.Where<Product>(p => p.VendorCode == product.VendorCode);
            if (filtered.Count() > 0)
            {
                int favIndex = customers[index].Favorites.IndexOf(filtered.ElementAt(0));
                customers[index].Favorites.RemoveAt(favIndex);
                File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                buttonAddToFavorites.Text = "Добавить в избранное";
                buttonAddToFavorites.Click += buttonAddToFavorites_Click;
            }
        }
    }
}
