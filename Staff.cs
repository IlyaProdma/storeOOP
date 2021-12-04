using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Staff : User
    {
        public Staff(string login, string password, AccessLevel access = AccessLevel.staff) : base(login, password, access)
        {
        }
    }
}
