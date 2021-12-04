using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Operation
    {
        private DateTime date;
        private Product product;

        public Operation(DateTime date, Product product)
        {
            this.date = date;
            this.product = product;
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public Product Product
        {
            get
            {
                return product;
            }
        }
    }
}
