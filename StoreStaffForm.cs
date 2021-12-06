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
        private DarkTreeNode MakeNode(Category category)
        {
            DarkTreeNode node = new DarkTreeNode(category.Name);
            if (category.Subcategories != null)
                foreach (Subcategory subcategory in category.Subcategories)
                    node.Nodes.Add(new DarkTreeNode(subcategory.Name));
            return node;
        }

        private void SetTreeview(List<Category> categories)
        {
            categoriesTree.Nodes.Clear();
            List<DarkTreeNode> treeNodes = new List<DarkTreeNode>();
            for (int i = 0; i < categories.Count; i++)
            {
                treeNodes.Add(MakeNode(categories[i]));
                categoriesTree.Nodes.Add(treeNodes[i]);
            }
        }

        private List<Category> readCategories()
            => JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));

        private List<Product> readProductsByCategory(string category)
            => JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
                .Where<Product>(p => p.Category == category || p.Subcategory == category).ToList();

        private string readImage(List<JsonImage> images, string vendorCode)
            => images.Where<JsonImage>(im => im.VendorCode == vendorCode).ElementAt(0).Image;

        private Product readProductByCode(string vendorCode)
            => JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
            .Where<Product>(p => p.VendorCode == vendorCode).ElementAt(0);

        private Customer readCustomerByLogin(string Login)
            => JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"))
            .Where<Customer>(cs => cs.Login == Login).ElementAt(0);
        public StoreStaffForm()
        {
            InitializeComponent();
            List<Category> categories = readCategories();
            SetTreeview(categories);
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
            List<Category> categories = readCategories();
            SetTreeview(categories);
            productsListView.Items.Clear();
        }

        private void createNewSubcategory(object sender, EventArgs e)
        {
            NewCategoryForm newSubcategory = new NewCategoryForm(false);
            newSubcategory.ShowDialog();
            List<Category> categories = readCategories();
            SetTreeview(categories);
            productsListView.Items.Clear();
        }

        private void redactCategory(object sender, EventArgs e)
        {
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));
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
            categories = readCategories();
            SetTreeview(categories);
            productsListView.Items.Clear();
        }

        private void categoriesTree_SelectedNodesChanged(object sender, EventArgs e)
        {
            if (categoriesTree.SelectedNodes.Count > 0)
            {
                List<Product> products = readProductsByCategory(categoriesTree.SelectedNodes[0].Text);
                darkSectionPanel2.SectionHeader = "Выбранная категория: " + categoriesTree.SelectedNodes[0].Text;
                productsListView.Items.Clear();
                ImageList imageList = new ImageList();
                imageList.ImageSize = new Size(200, 200);
                List<JsonImage> images = JsonConvert.DeserializeObject<List<JsonImage>>(File.ReadAllText("data/images.json"));
                foreach (Product product in products)
                {
                    imageList.Images.Add(new Bitmap(readImage(images, product.VendorCode)));
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
                    ListViewItem item = new ListViewItem(new string[] { String.Format("{0} - {1}р", products[i].Name, products[i].PriceRetail.ToString()),
                                                                        products[i].VendorCode, readImage(images, products[i].VendorCode)});
                    item.ImageIndex = i;
                    productsListView.Items.Add(item);
                }
            }
        }
    }
}
