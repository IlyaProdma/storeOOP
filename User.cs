using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Store
{

    public enum AccessLevel
    {
        undefined = 0,
        customer,
        staff,
        supervisor
    }
    public class User
    {
        protected string login;
        protected string password;
        protected AccessLevel access;

        public User(string login, string password, AccessLevel access = AccessLevel.undefined)
        {
            this.login = login;
            //byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
            //this.password = BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(tmpSource));
            this.password = password;
            this.access = access;
        }

        public string Login
        {
            get
            {
                return login;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

        public AccessLevel Access
        {
            get
            {
                return access;
            }
        }
    }
}
