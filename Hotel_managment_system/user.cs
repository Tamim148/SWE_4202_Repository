using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_managment_system
{
    internal class user
    {
        private string ID;
        private string name;
        private string phone;
        private string address;

        public string getid()
        {
            return ID;
        }
        public void setuser(string ID,string name,string phone,string address)
        {
            this.ID = ID;
            this.name = name;
            this.phone = phone;
            this.address = address;

        }

        public bool checkifUserExist(string UserID)
        {
            if (UserID == ID)
                return true;
            else return false;
        }
    }
}
