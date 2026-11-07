using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Billing_System
{
    class Cashier
    {
        public string cashier_name { get; set; }
        public string telephone { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }

        public Cashier (string cashiername, string teleno, string username, string pass)
        {
            cashier_name = cashiername;
            telephone = teleno;
            user_name = username;
            password = pass;
        }

    }
}
