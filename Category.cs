using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Category
    {
        protected string name;
        private List<Subcategory> subcategories;
        protected List<Product> products;

        public Category(string name)
        {
            this.name = name;
            subcategories = new List<Subcategory>();
            products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<Subcategory> Subcategories
        {
            get
            {
                return subcategories;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
        }
    }
}
