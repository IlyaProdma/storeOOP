using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkUI.Forms;
using DarkUI.Controls;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using System.ComponentModel;

namespace Store
{
    public static class Utils
    {
        public static string getDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return "test";
        }
        private static DarkTreeNode makeNode(Category category)
        {
            DarkTreeNode node = new DarkTreeNode(category.Name);
            if (category.Subcategories != null)
                foreach (Subcategory subcategory in category.Subcategories)
                    node.Nodes.Add(new DarkTreeNode(subcategory.Name));
            return node;
        }

        public static void setTreeview(List<Category> categories, DarkTreeView categoriesTree)
        {
            categoriesTree.Nodes.Clear();
            List<DarkTreeNode> treeNodes = new List<DarkTreeNode>();
            categoriesTree.Nodes.Add(makeNode(new Category("Все товары")));
            for (int i = 0; i < categories.Count; i++)
            {
                treeNodes.Add(makeNode(categories[i]));
                categoriesTree.Nodes.Add(treeNodes[i]);
            }
        }

        public static List<Category> readAllCategories()
            => JsonConvert.DeserializeObject<List<Category>>(File.ReadAllText("data/categories.json"));

        public static void writeCategories(List<Category> categories)
            => File.WriteAllText("data/categories.json", JsonConvert.SerializeObject(categories, Formatting.Indented));

        public static Customer readCustomerByLogin(string Login)
            => JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"))
            .Where<Customer>(cs => cs.Login == Login).ElementAt(0);

        public static List<Customer> readAllCustomers()
            => JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText("data/customers.json"));

        public static void writeCustomers(List<Customer> customers)
            => File.WriteAllText("data/customers.json", JsonConvert.SerializeObject(customers, Formatting.Indented));

        public static List<Product> readAllProducts()
            => JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"));

        public static List<Product> readProductsByCategory(string category)
            => JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
                .Where<Product>(p => p.Category == category || p.Subcategory == category).ToList();

        public static void writeProducts(List<Product> products)
            => File.WriteAllText("data/products.json", JsonConvert.SerializeObject(products, Formatting.Indented));

        public static string readImage(List<JsonImage> images, string vendorCode)
            => images.Where<JsonImage>(im => im.VendorCode == vendorCode).ElementAt(0).Image;

        public static List<JsonImage> readAllImages()
            => JsonConvert.DeserializeObject<List<JsonImage>>(File.ReadAllText("data/images.json"));

        public static void writeImages(List<JsonImage> images)
            => File.WriteAllText("data/images.json", JsonConvert.SerializeObject(images, Formatting.Indented));

        public static Product readProductByCode(string vendorCode)
            => JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText("data/products.json"))
            .Where<Product>(p => p.VendorCode == vendorCode).ElementAt(0);

        public static void fillProductsListView(ListView productsListView, List<Product> products)
        {
            productsListView.Items.Clear();
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(200, 200);
            List<JsonImage> images = JsonConvert.DeserializeObject<List<JsonImage>>(File.ReadAllText("data/images.json"));
            foreach (Product product in products)
            {
                imageList.Images.Add(new Bitmap(Utils.readImage(images, product.VendorCode)));
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
                                                                    Utils.readImage(images, products[i].VendorCode) });
                item.ImageIndex = i;
                productsListView.Items.Add(item);
            }
        }
    }
}
