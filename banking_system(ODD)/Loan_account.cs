using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking_system
{
    internal class Loan_account:Account
    {
        public void interest(double amm)
        {
            amm += (amm * (9 / 100));
        }
    }
}
