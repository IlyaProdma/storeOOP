using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Store
{

    enum AccessLevel
    {
        undefined = 0,
        customer,
        staff,
        supervisor
    }
    class User
    {
        private string login;
        private byte[] password;
        private AccessLevel access;

        public User(string login, string password, AccessLevel access = AccessLevel.undefined)
        {
            this.login = login;
            byte[] tmpSource = UTF8Encoding.UTF8.GetBytes(password);
            this.password = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            this.access = access;
        }
    }
}
