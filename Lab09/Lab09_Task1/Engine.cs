using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Engine
    {
        private int MaximumFuelConsumptionRate = 100;
        public int getFuelConsumption()
        {
            return this.MaximumFuelConsumptionRate;
        }
        public void setFuelConsumption(int rate)
        {
            this.MaximumFuelConsumptionRate = rate;
        }
        private int MaximumEnergyProductionRate = 200;
        public int getEnergyProduction()
        {
            return this.MaximumEnergyProductionRate;
        }
        public void setEnergyProduction(int rate)
        {
            this.MaximumEnergyProductionRate = rate;
        }
        private int AverageRPM = 5000;
        public int getRPM()
        {
            return this.AverageRPM;
        }
        public void setRPM(int RPM)
        {
            this.AverageRPM = RPM;
        }
    }
}
