using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task2
{
    internal class Typist : Staff
    {
        public string TypingSpeed="70 WPM";

        public override string whoAmI()
        {
            return "I am a typist";
        }
    }
}
