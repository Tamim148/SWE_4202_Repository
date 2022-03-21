using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        public string medName;
        public int medQty=0;
        private int medUnitPrice;
        public int medUnitBought=0;

        public int getMedUnitPrice ()
        {
            return this.medUnitPrice;
        }

        public void setMedUnitPrice (int medPrice)
        {
            this.medUnitPrice = medPrice;
        }
    }
}
