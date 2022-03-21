using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task2
{
    internal class Staff
    {
        public string Code = "00";
        public string Name = "tasnim ahmed";
        private string jobStatus = "Fired";
        protected string Money = "0";
        internal string security = "None";
        internal protected string Respect = "MAX";
            // private modifier is not inherited by the child classes
        public string getjobStatus()
        {
            return this.jobStatus;
        }
        public void setjobStatus(string status)
        {
            this.jobStatus = status;
        }

        public virtual string whoAmI()
            {
                return "I am a staff";
            }
    }
}
