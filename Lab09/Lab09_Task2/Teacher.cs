using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task2
{
    internal class Teacher : Staff
    {
        public string subject="boring";
        public string publication="ruponti";

        public override string whoAmI()
        {
            return "I am a Teacher";
        }
    }
}
