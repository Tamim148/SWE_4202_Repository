using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab
    {
        private string labName;
        private int capacity;

        public string getLabName()
        {
            return labName;
        }
        public int getCapacity()
        {
            return capacity;
        }
        public void setLabName(string Name)
        {
            this.labName = Name;
        }
        public void setCapacity(int Cap)
        {
            this.capacity = Cap;
        }
    }
}
