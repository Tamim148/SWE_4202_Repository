using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_Sysytem
{
    internal class CAR_CLASS
    {
        public string model;
        public string name;
        public string manufacturer;
        public string YOM;
        public int numbers;

        public void setterofCar(string model, string name, string manufacturer, string YOM, int numbers)
        {
            this.model = model;
            this.name = name;
            this.manufacturer = manufacturer;
            this.YOM = YOM;
            this.numbers = numbers;
        }

        public string getCAR()

        {
            string value = "The model " + model + " of " + name + " has " + Convert.ToString(numbers) + " cars";
            return value;
        }

        public bool checkMODEL(string value)
        {
            if (value == model)
                return true;
            else
                return false;
        }
        public bool checknumber()
        {
            if (numbers >0)
                return true;
            else
                return false;
        }

        public void Decreasecars()
        {
            numbers = numbers - 1;
        }








    }
}
