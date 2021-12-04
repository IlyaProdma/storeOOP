using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        private string name;
        private string vendorCode;
        private double priceRetail;
        private double priceWholesale;
        private uint quantityInStock;
        private double mass;
        private string manufacturer;
        private string placeOfProduction;
        private string productionSeries;
        private string category;
        private string subcategory;

        public Product(string name, string vendorCode, string category,
            string subcategory, double priceRetail = 0, double priceWholesale = 0,
            uint quantityInStock = 0, double mass = 0, string manufacturer = "undefined",
            string placeOfProduction = "undefined", string productionSeries = "undefined")
        {
            this.name = name;
            this.vendorCode = vendorCode;
            this.category = category;
            this.subcategory = subcategory;
            this.priceRetail = priceRetail;
            this.priceWholesale = priceWholesale;
            this.quantityInStock = quantityInStock;
            this.mass = mass;
            this.manufacturer = manufacturer;
            this.placeOfProduction = placeOfProduction;
            this.productionSeries = productionSeries;
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

        public string VendorCode
        {
            get
            {
                return vendorCode;
            }
            set
            {
                vendorCode = value;
            }
        }

        public double PriceRetail
        {
            get
            {
                return priceRetail;
            }
            set
            {
                priceRetail = value;
            }
        }

        public double PriceWholesale
        {
            get
            {
                return priceWholesale;
            }
            set
            {
                priceWholesale = value;
            }
        }

        public uint QuantityInStock
        {
            get
            {
                return quantityInStock;
            }
            set
            {
                quantityInStock = value;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }

        public string PlaceOfProduction
        {
            get
            {
                return placeOfProduction;
            }
            set
            {
                placeOfProduction = value;
            }
        }

        public string ProductionSeries
        {
            get
            {
                return productionSeries;
            }
            set
            {
                productionSeries = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        
        public string Subcategory
        {
            get
            {
                return subcategory;
            }
            set
            {
                subcategory = value;
            }
        }

    }
}
