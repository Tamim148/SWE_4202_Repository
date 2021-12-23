using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Sysytem
{
    internal class USER_CLASS
    {

        public string name;
        public int ID;
        public string address;
        public string destination;
        public string phone;

        public void setterofUSER( string name,int ID,string address,string destination,string phone)
        {
            this.name = name;
            this.ID = ID;
            this.address = address;
            this.destination = destination;
            this.phone = phone;

        }


        public string getterofUser()
        {
            string value = name + " " + Convert.ToString(ID) + " " + address + " " + phone;
            return value;
        }
        public bool checkID(string id)
        {
            if (id == Convert.ToString(ID))
                return true;
            else
                return false;
        }


    }
}
