using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task2
{
    internal class Officer : Staff
    {
        public string grade="A";

        public override string whoAmI()
        {
            return "I am an Officer";
        }
    }
}
