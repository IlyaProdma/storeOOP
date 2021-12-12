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
    public partial class StoreStaffForm : DarkForm
    {
        public StoreStaffForm()
        {
            InitializeComponent();
            List<Category> categories = Utils.readAllCategories();
            Utils.setTreeview(categories, categoriesTree);
        }

        private void categoriesTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu actions = new ContextMenu(new MenuItem[] { new MenuItem() { Text = "Новая категория"},
                                                                       new MenuItem() { Text = "Новая подкатегория" }});
                actions.MenuItems[0].Click += createNewCategory;
                actions.MenuItems[1].Click += createNewSubcategory;
                if (categoriesTree.SelectedNodes.Count > 0)
                {
                    actions.MenuItems.Add(new MenuItem() { Text = "Редактировать" });
                    actions.MenuItems[2].Click += redactCategory;
                }
                actions.Show(this, new Point(e.X, e.Y));
            }
        }

        private void createNewCategory(object sender, EventArgs e)
        {
            NewCategoryForm newCategory = new NewCategoryForm(true);
            newCategory.ShowDialog();
            List<Category> categories = Utils.readAllCategories();
            Utils.setTreeview(categories, categoriesTree);
            productsListView.Items.Clear();
        }

        private void createNewSubcategory(object sender, EventArgs e)
        {
            NewCategoryForm newSubcategory = new NewCategoryForm(false);
            newSubcategory.ShowDialog();
            List<Category> categories = Utils.readAllCategories();
            Utils.setTreeview(categories, categoriesTree);
            productsListView.Items.Clear();
        }

        private void redactCategory(object sender, EventArgs e)
        {
            List<Category> categories = Utils.readAllCategories();
            if (categories.Find(cat => cat.Name.Equals(categoriesTree.SelectedNodes[0].Text)) != null)
            {
                RedactCategoryForm redactCategory = new RedactCategoryForm(categoriesTree.SelectedNodes[0].Text, true);
                redactCategory.ShowDialog();
            }
            else
            {
                RedactCategoryForm redactCategory = new RedactCategoryForm(categoriesTree.SelectedNodes[0].Text,
                                                                           false,
                                                                           categoriesTree.SelectedNodes[0].ParentNode.Text);
                redactCategory.ShowDialog();
            }
            categories = Utils.readAllCategories();
            Utils.setTreeview(categories, categoriesTree);
            productsListView.Items.Clear();
        }

        private void categoriesTree_SelectedNodesChanged(object sender, EventArgs e)
        {
            if (categoriesTree.SelectedNodes.Count > 0)
            {
                darkSectionPanel2.SectionHeader = "Выбранная категория: " + categoriesTree.SelectedNodes[0].Text;
                List<Product> products = Utils.readAllProducts();
                if (categoriesTree.SelectedNodes[0].Text != "Все товары")
                {
                    if (products != null)
                        products = Utils.readProductsByCategory(categoriesTree.SelectedNodes[0].Text);
                }
                if (products != null)
                    Utils.fillProductsListView(productsListView, products);
            }
        }

        private void productsListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = productsListView.HitTest(e.X, e.Y).Item;
            if (item != null)
            {
                string cat = categoriesTree.SelectedNodes[0].Text;
                RedactProductInfo productInfo = new RedactProductInfo(Utils.readProductByCode(item.SubItems[1].Text),
                                                                      item.SubItems[2].Text);
                productInfo.ShowDialog();
                Utils.setTreeview(Utils.readAllCategories(), categoriesTree);
                productsListView.Items.Clear();
            }
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            RedactProductInfo redactProductInfo = new RedactProductInfo();
            redactProductInfo.ShowDialog();
            Utils.setTreeview(Utils.readAllCategories(), categoriesTree);
            productsListView.Items.Clear();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            RedactOperationsForm redactOperations = new RedactOperationsForm();
            redactOperations.ShowDialog();
        }
    }
}
