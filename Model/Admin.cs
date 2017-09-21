using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Admin
    {
        private String id;
        private String password;
        private int privilege;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Privilege
        {
            get { return privilege; }
            set { privilege = value; }
        }
        public Admin()
        {

        }
    }
}
