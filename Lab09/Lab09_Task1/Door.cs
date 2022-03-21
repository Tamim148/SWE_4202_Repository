using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Door
    {
        private string OpeningMode = "sideways";
        public string getDoorOpeningMode()
        {
            return this.OpeningMode;
        }
        public void setDoorOpeningMode(string mode)
        {
            this.OpeningMode = mode;
        }
    }
}
