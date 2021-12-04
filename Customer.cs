using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Customer : User
    {
        private List<Product> favorites;
        private List<Product> cart;
        private List<Operation> operations;
        public Customer(string login, string password, List<Product> favorites = null, 
                        List<Product> cart = null, List<Operation> operations = null,
                        AccessLevel access = AccessLevel.customer) : base(login, password, access)
        {
            this.favorites = favorites;
            this.cart = cart;
            this.operations = operations;
            if (this.favorites == null)
            {
                this.favorites = new List<Product>();
                this.cart = new List<Product>();
                this.operations = new List<Operation>();
            }
        }

        public List<Product> Favorites
        {
            get
            {
                return favorites;
            }
        }

        public List<Product> Cart
        {
            get
            {
                return cart;
            }
        }

        public List<Operation> Operations
        {
            get
            {
                return operations;
            }
        }
    }
}
