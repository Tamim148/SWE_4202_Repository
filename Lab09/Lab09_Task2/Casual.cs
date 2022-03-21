using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task2
{
    internal class Casual : Typist
    {
        public string daily = "grind";
        public string wages = "unpaid";

        public override string whoAmI()
        {
            return "I am a casual typist.";
        }
    }
}
