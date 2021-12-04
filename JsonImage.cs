using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class JsonImage
    {
        private string vendorCode;
        private string image;

        public JsonImage(string vendorCode, string image)
        {
            this.vendorCode = vendorCode;
            this.image = image;
        }

        public string VendorCode
        {
            get
            {
                return vendorCode;
            }
        }

        public string Image
        {
            get
            {
                return image;
            }
        }
    }
}
