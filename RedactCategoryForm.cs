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
    public partial class RedactCategoryForm : DarkForm
    {
        private string CategoryName;
        private string ParentName;
        private bool CategoryNotSubcategory;
        public RedactCategoryForm(string CategoryName, bool CategoryNotSubcategory, string ParentName = "")
        {
            InitializeComponent();
            this.CategoryName = CategoryName;
            this.ParentName = ParentName;
            this.CategoryNotSubcategory = CategoryNotSubcategory;
            List<Product> products;
            if (CategoryNotSubcategory)
            {
                darkSectionPanel1.SectionHeader = string.Format("Товары категории \"{0}\"", CategoryName);                
                products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
                                        .Where<Product>(p => p.Category.Equals(CategoryName)).ToList();
                foreach (Product product in products)
                {
                    productsListView.Items.Add(new ListViewItem(new string[] { product.Name, product.Subcategory}));
                }
            }
            else
            {
                productsListView.Columns.Clear();
                productsListView.Columns.Add("Название", 200);
                buttonClearCat.Text = "Очистить подкатегорию";
                buttonDeleteCat.Text = "Удалить подкатегорию";
                darkSectionPanel1.SectionHeader = string.Format("Товары подкатегории \"{0}\"", CategoryName);
                products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
                                        .Where<Product>(p => p.Subcategory.Equals(CategoryName)).ToList();
                foreach (Product product in products)
                {
                    productsListView.Items.Add(new ListViewItem(new string[] { product.Name}));
                }
            }
            if (products.Count > 0)
            {
                buttonClearCat.Enabled = true;
            }
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            List<Product> allProducts = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));
            for (int i = 0; i < productsListView.Items.Count; ++i)
            {
                if (productsListView.Items[i].Selected)
                {
                    foreach(Product product in allProducts)
                    {
                        if (product.Name == productsListView.Items[i].SubItems[0].Text && CategoryNotSubcategory == true)
                        {
                            product.Category = "";
                            product.Subcategory = "";
                        }
                        else if (product.Name == productsListView.Items[i].SubItems[0].Text && CategoryNotSubcategory == false)
                        {
                            product.Subcategory = "";
                        }
                    }
                    productsListView.Items.RemoveAt(i);
                    --i;
                }
            }
            File.WriteAllText("data/products.json", JsonConvert.SerializeObject(allProducts, Formatting.Indented));
        }

        private void productsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsListView.SelectedItems.Count > 0)
            {
                buttonDeleteSelected.Enabled = true;
            }
            else
            {
                buttonDeleteSelected.Enabled = false;
            }
        }

        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            if (CategoryNotSubcategory)
            {
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));
                if (categories.Find(cat => cat.Name.Equals(newNameTextBox.Text)) != null)
                {
                    MessageBox.Show("Такая категория уже существует!");
                }
                else
                {
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));
                    foreach (var product in products)
                    {
                        if (product.Category.Equals(CategoryName))
                        {
                            product.Category = newNameTextBox.Text;
                        }
                    }
                    File.WriteAllText("data/products.json", JsonConvert.SerializeObject(products, Formatting.Indented));
                    List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
                    foreach (var customer in customers)
                    {
                        foreach (var product in customer.Cart)
                        {
                            if (product.Category.Equals(CategoryName))
                            {
                                product.Category = newNameTextBox.Text;
                            }
                        }
                        foreach (var product in customer.Favorites)
                        {
                            if (product.Category.Equals(CategoryName))
                            {
                                product.Category = newNameTextBox.Text;
                            }
                        }
                    }
                    File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                    categories.Find(cat => cat.Name.Equals(CategoryName)).Name = newNameTextBox.Text;
                    File.WriteAllText("data/categories.json", JsonConvert.SerializeObject(categories, Formatting.Indented));
                    darkSectionPanel1.SectionHeader = string.Format("Товары категории \"{0}\"", newNameTextBox.Text);
                    MessageBox.Show(string.Format("Категория \"{0}\" была успешно переименована в \"{1}\"", CategoryName,
                                    newNameTextBox.Text));
                    Close();
                }
            }
            else
            {
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));
                if (categories.Find(cat => cat.Name.Equals(ParentName)).Subcategories
                    .Find(sub => sub.Name.Equals(newNameTextBox.Text)) != null)
                {
                    MessageBox.Show("Такая подкатегория уже существует!");
                }
                else
                {
                    List<Product> products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));
                    foreach (var product in products)
                    {
                        if (product.Subcategory.Equals(CategoryName))
                        {
                            product.Subcategory = newNameTextBox.Text;
                        }
                    }
                    File.WriteAllText("data/products.json", JsonConvert.SerializeObject(products, Formatting.Indented));
                    List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
                    foreach (var customer in customers)
                    {
                        foreach (var product in customer.Cart)
                        {
                            if (product.Subcategory.Equals(CategoryName))
                            {
                                product.Subcategory = newNameTextBox.Text;
                            }
                        }
                        foreach (var product in customer.Favorites)
                        {
                            if (product.Subcategory.Equals(CategoryName))
                            {
                                product.Subcategory = newNameTextBox.Text;
                            }
                        }
                    }
                    File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
                    categories.Find(cat => cat.Name.Equals(ParentName)).Subcategories
                        .Find(sub => sub.Name.Equals(CategoryName)).Name = newNameTextBox.Text;
                    File.WriteAllText("data/categories.json", JsonConvert.SerializeObject(categories, Formatting.Indented));
                    darkSectionPanel1.SectionHeader = string.Format("Товары подкатегории \"{0}\"", newNameTextBox.Text);
                    MessageBox.Show(string.Format("Подкатегория \"{0}\" была успешно переименована в \"{1}\"", CategoryName,
                                    newNameTextBox.Text));
                    Close();
                }
            }

        }

        private void buttonClearCat_Click(object sender, EventArgs e)
        {
            productsListView.Items.Clear();
            List<Product> allProducts = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            if (CategoryNotSubcategory)
            {
                foreach (Product product in allProducts)
                {
                    if (product.Category == CategoryName)
                    {
                        product.Category = "";
                        product.Subcategory = "";
                    }
                }
                foreach (Customer customer in customers)
                {
                    foreach (Product product in customer.Cart)
                    {
                        if (product.Category == CategoryName)
                        {
                            product.Category = "";
                            product.Subcategory = "";
                        }
                    }
                    foreach (Product product in customer.Favorites)
                    {
                        if (product.Category == CategoryName)
                        {
                            product.Category = "";
                            product.Subcategory = "";
                        }
                    }
                }
            }
            else
            {
                foreach (Product product in allProducts)
                {
                    if (product.Subcategory == CategoryName)
                    {
                        product.Subcategory = "";
                    }
                }
                foreach (Customer customer in customers)
                {
                    foreach (Product product in customer.Cart)
                    {
                        if (product.Subcategory == CategoryName)
                        {
                            product.Subcategory = "";
                        }
                    }
                    foreach (Product product in customer.Favorites)
                    {
                        if (product.Subcategory == CategoryName)
                        {
                            product.Subcategory = "";
                        }
                    }
                }
            }
            File.WriteAllText("data/products.json", JsonConvert.SerializeObject(allProducts, Formatting.Indented));
            File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
            if (CategoryNotSubcategory)
                MessageBox.Show(string.Format("Категория \"{0}\" была успешно очищена", CategoryName));
            else
                MessageBox.Show(string.Format("Подкатегория \"{0}\" была успешно очищена", CategoryName));
            Close();
        }

        private void newNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (newNameTextBox.Text.Length > 0)
            {
                buttonChangeName.Enabled = true;
            }
            else
            {
                buttonChangeName.Enabled = false;
            }
        }

        private void buttonDeleteCat_Click(object sender, EventArgs e)
        {
            List<Product> allProducts = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));
            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));
            if (CategoryNotSubcategory)
            {
                foreach (Product product in allProducts)
                {
                    if (product.Category == CategoryName)
                    {
                        product.Category = "";
                        product.Subcategory = "";
                    }
                }
                foreach (Customer customer in customers)
                {
                    foreach (Product product in customer.Cart)
                    {
                        if (product.Category == CategoryName)
                        {
                            product.Category = "";
                            product.Subcategory = "";
                        }
                    }
                    foreach (Product product in customer.Favorites)
                    {
                        if (product.Category == CategoryName)
                        {
                            product.Category = "";
                            product.Subcategory = "";
                        }
                    }
                }
                categories.RemoveAt(categories.FindIndex(cat => cat.Name.Equals(CategoryName)));
            }
            else
            {
                foreach (Product product in allProducts)
                {
                    if (product.Subcategory == CategoryName)
                    {
                        product.Subcategory = "";
                    }
                }
                foreach (Customer customer in customers)
                {
                    foreach (Product product in customer.Cart)
                    {
                        if (product.Subcategory == CategoryName)
                        {
                            product.Subcategory = "";
                        }
                    }
                    foreach (Product product in customer.Favorites)
                    {
                        if (product.Subcategory == CategoryName)
                        {
                            product.Subcategory = "";
                        }
                    }
                }
                categories.Find(cat => cat.Name.Equals(ParentName)).Subcategories
                    .RemoveAt(categories.Find(cat => cat.Name.Equals(ParentName))
                    .Subcategories.FindIndex(sub => sub.Name.Equals(CategoryName)));
            }
            File.WriteAllText("data/products.json", JsonConvert.SerializeObject(allProducts, Formatting.Indented));
            File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));
            File.WriteAllText("data/categories.json", JsonConvert.SerializeObject(categories, Formatting.Indented));
            if (CategoryNotSubcategory)
                MessageBox.Show(string.Format("Категория \"{0}\" была успешно удалена", CategoryName));
            else
                MessageBox.Show(string.Format("Подкатегория \"{0}\" была успешно удалена", CategoryName));
            Close();
        }
    }
}
