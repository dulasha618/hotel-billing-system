using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Billing_System
{
    class Setting
    {
        public string admin_name { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }

        public Setting (string adminname, string username, string pass)
        {
            admin_name = adminname;
            user_name = username;
            password = pass;
        }
    }
}
