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
using DarkUI.Controls;
using DarkUI.Forms;
using Newtonsoft.Json;

namespace Store
{
    public partial class IndividualProductsListForm : DarkForm
    {
        private List<Product> products;
        private string Login;
        private bool CartNotFavorites;
        public IndividualProductsListForm(string Login, bool CartNotFavorites)
        {
            InitializeComponent();
            this.Login = Login;
            this.CartNotFavorites = CartNotFavorites;
            panelWindowName.SectionHeader = CartNotFavorites ? "Корзина" : "Избранное";
            productsListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            List<JsonImage> images = Utils.readAllImages();
            products = CartNotFavorites ? 
                                     Utils.readAllCustomers().Where<Customer>(cs => cs.Login == Login).ElementAt(0).Cart 
                                    : Utils.readAllCustomers().Where<Customer>(cs => cs.Login == Login).ElementAt(0).Favorites;
            buttonBuy.Enabled = buttonDeleteFrom.Enabled = products.Count > 0;
            foreach (Product product in products)
            {
                imageList.Images.Add(new Bitmap(images.Where<JsonImage>(im => im.VendorCode == product.VendorCode)
                                                    .ElementAt(0).Image));
            }

            Bitmap emptyImage = new Bitmap(200, 200);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            imageList.Images.Add(emptyImage);
            productsListView.LargeImageList = imageList;
            for (int i = 0; i < products.Count; ++i)
            {
                ListViewItem item = new ListViewItem(new string[] { String.Format("{0} - {1}р",
                                                                    products[i].Name,
                                                                    products[i].PriceRetail.ToString()),
                                                                    products[i].VendorCode,
                                                                    images.Where<JsonImage>(im => im.VendorCode == products[i].VendorCode)
                                                                        .ElementAt(0).Image});
                item.ImageIndex = i;
                productsListView.Items.Add(item);
            }
            if (CartNotFavorites)
            {
                this.Text = "Корзина";
                buttonBuy.Click += buttonBuy_Click;
                panelOperationsList.Visible = true;
                buttonBuy.Text = string.Format("Совершить покупку ({0}р)", products.Sum<Product>(p => p.PriceRetail));
                List<Operation> operations = Utils.readAllCustomers().Where<Customer>(cs => cs.Login == Login)
                                                .ElementAt(0).Operations;
                foreach (Operation operation in operations)
                {
                    operationsListView.Items.Add(new DarkListItem(string.Format("{0} - {1} - {2}",
                                                                                operation.Product,
                                                                                operation.Date,
                                                                                operation.Status.getDescription())));
                }
            }
            else
            {
                this.Text = "Избранные товары";
                buttonBuy.Text = "Добавить выделенное в корзину";
                panelOperationsList.Visible = false;
            }
        }

        private void buttonDeleteFrom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < productsListView.Items.Count; ++i)
            {
                if (productsListView.Items[i].Selected)
                {
                    products.RemoveAt(products.IndexOf(products.Find(p => p.VendorCode == productsListView.Items[i].SubItems[1].Text)));
                    productsListView.Items.RemoveAt(i);
                    --i;

                }
            }
            List<Customer> customers = Utils.readAllCustomers();
            buttonBuy.Text = string.Format("Совершить покупку ({0}р)", products.Sum<Product>(p => p.PriceRetail));
            if (CartNotFavorites)
                customers.Find(cs => cs.Login == Login).Cart = products;
            else
                customers.Find(cs => cs.Login == Login).Favorites = products;
            Utils.writeCustomers(customers);
            if (products.Count <= 0)
            {
                buttonDeleteFrom.Enabled = false;
                buttonBuy.Enabled = false;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            List<Customer> customers = Utils.readAllCustomers();
            Customer customer = customers.Find(cs => cs.Login == Login);
            if (customer.Cart.Find(p => p.QuantityInStock <= 0) != null)
            {
                string listOfAbsentProducts = "Операция невозможна. Следующие продукты отсутствуют в наличии: ";
                foreach (Product product in customer.Cart.Where(p => p.QuantityInStock <= 0))
                {
                    listOfAbsentProducts += string.Format("\"{0}\"\n", product.Name);
                }
                DarkMessageBox.ShowError(listOfAbsentProducts, "Ошибка");
            }
            else
            {
                foreach (Product product in customer.Cart)
                {
                    DateTime date = DateTime.Now;
                    customer.Operations.Add(new Operation(date, product.Name, OperationStatus.Processing));
                    operationsListView.Items.Add(new DarkListItem(string.Format("{0} - {1} - {2}", product.Name,
                                                                                date,
                                                                                OperationStatus.Processing.getDescription())));
                }
                customer.Cart.Clear();
                productsListView.Items.Clear();
                buttonBuy.Text = "Совершить покупку (0р)";
                buttonBuy.Enabled = false;
                Utils.writeCustomers(customers);
            }
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            List<Customer> customers = Utils.readAllCustomers();
            int index = customers.IndexOf(customers.Where<Customer>(cs => cs.Login == Login).ElementAt(0));
            foreach (Product product in products)
            {
                customers[index].Cart.Add(product);
            }
            Utils.writeCustomers(customers);
        }
    }
}
