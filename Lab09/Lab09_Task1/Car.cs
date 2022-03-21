using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Car
    {
        public Seat seats = new Seat();
        public Door doors = new Door();
        public Engine engine = new Engine();
        public Wheel wheels = new Wheel();
        private int maximum_accelaration = 250;
        public int getMaxAccelaration()
        {
            return this.maximum_accelaration;
        }
        public void setMaxAccelaration(int max)
        {
            this.maximum_accelaration = max;
        }
        private int fuel_capacity = 25000;
        public int getFuelCapacity()
        {
            return this.fuel_capacity;
        }
        public void setFuelCapacity(int fuel)
        {
            this.fuel_capacity = fuel;
        }
        public string DisplayInfo()
        {
            string info = Convert.ToString(getFuelCapacity()) +"\n"+ Convert.ToString(getMaxAccelaration())+"\n" + seats.getSeatComfortability()+"\n" + Convert.ToString(seats.getSeatWarmerStatus())+"\n"+ Convert.ToString(wheels.getWheelCircumference())+"\n"+doors.getDoorOpeningMode()+"\n"+Convert.ToString(engine.getEnergyProduction())+ "\n" + Convert.ToString(engine.getFuelConsumption())+ "\n" + Convert.ToString(engine.getRPM());
            return info;
        }
    }
}
