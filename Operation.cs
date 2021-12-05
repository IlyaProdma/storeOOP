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
        private string product;

        public Operation(DateTime date, string product)
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

        public string Product
        {
            get
            {
                return product;
            }
        }
    }
}
