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
            List<DarkTreeNode> treeNodes = new List<DarkTreeNode>();
            for (int i = 0; i < categories.Count; i++)
            {
                treeNodes.Add(MakeNode(categories[i]));
                categoriesTree.Nodes.Add(treeNodes[i]);
            }
        }

        private void AddNodes(List<Category> categories)
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
            => JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("categories.json"));

        private List<Product> readProducts(string category)
            => (List<Product>)JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("products.json"))
                .Where<Product>(p => p.Category == category || p.Subcategory == category);


        public StoreCustomerForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            List<Category> categories = readCategories();
            SetTreeview(categories);

        }

        private void categoriesTree_SelectedNodesChanged(object sender, EventArgs e)
        {
            //List<Product> products = readProducts(categoriesTree.SelectedNodes[0].Text);
            productsTable.Columns.Clear();
            var column = new DataGridViewTextBoxColumn();
            column.Name = "Name";
            column.HeaderText = "Название";
            productsTable.Columns.Add(column);
        }
    }
}
