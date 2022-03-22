using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    internal class Account
    {
        public string name;
        public string id;
        public double amount;

        public void setAccount( string name,string id,double amount)
        {
            this.name = name;
            this.id = id;
            this.amount = amount;

        }

        public List<Transactions> tran_slist = new List<Transactions>();

    }
}
