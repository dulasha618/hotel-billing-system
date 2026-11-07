using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Billing_System
{
    class Products
    {
        public string product_name { get; set; }
        public string price { get; set; }
        public string category { get; set; }


        public Products (string productname, string pric, string catey)
        {
            product_name = productname;
            price = pric;
            category = catey;
        }

    }

   
}
 