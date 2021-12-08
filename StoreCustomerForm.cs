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
    public partial class StoreCustomerForm : DarkForm
    {
        private Customer customer;

        public StoreCustomerForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            List<Category> categories = Utils.readAllCategories();
            Utils.setTreeview(categories, categoriesTree);

        }

        private void categoriesTree_SelectedNodesChanged(object sender, EventArgs e)
        {
            if (categoriesTree.SelectedNodes.Count > 0)
            {
                darkSectionPanel2.SectionHeader = "Выбранная категория: " + categoriesTree.SelectedNodes[0].Text;
                List<Product> products;
                if (categoriesTree.SelectedNodes[0].Text != "Все товары")
                {
                    products = Utils.readProductsByCategory(categoriesTree.SelectedNodes[0].Text);
                }
                else
                {
                    products = Utils.readAllProducts();
                }
                Utils.fillProductsListView(productsListView, products);
            }
        }

        private void productsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = productsListView.HitTest(e.X, e.Y).Item;
            if (item != null)
            {
                customer = Utils.readCustomerByLogin(customer.Login);
                ProductInfoForm productInfo = new ProductInfoForm(customer,
                    Utils.readProductByCode(item.SubItems[1].Text), item.SubItems[2].Text);
                productInfo.ShowDialog();
            }

        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            IndividualProductsListForm cartForm = new IndividualProductsListForm(customer.Login, true);
            cartForm.ShowDialog();
        }

        private void buttonFavorites_Click(object sender, EventArgs e)
        {
            IndividualProductsListForm favsForm = new IndividualProductsListForm(customer.Login, false);
            favsForm.ShowDialog();
        }

        private void buttonOperations_Click(object sender, EventArgs e)
        {
            CustomerOperationsForm csOpForm = new CustomerOperationsForm(customer.Operations);
            csOpForm.ShowDialog();
        }
    }
}
