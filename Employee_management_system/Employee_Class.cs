using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system
{
    internal class Employee_Class
    {
        public string id;
        public string name;
        public string contact;
        public string DOT;
        public double salary;
        public double leaves;

        public void setEmployee(string id, string name, string contact, string DOT, double salary, double leaves)
        {
            this.id = id;
            this.name = name;
            this.contact = contact;
            this.DOT = DOT;
            this.salary = salary;
            this.leaves = leaves;

        }

        public string getter()
        {
            string get = id + "   " + name + "   " + DOT + "   " + contact + "   " + salary.ToString();
            return get;
        }

    }
}
