using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    internal class Seat
    {
        private string Comfortability = "Pleasant";
        public string getSeatComfortability()
        {
            return this.Comfortability;
        }
        public void setSeatComfortability(string comfort)
        {
            this.Comfortability = comfort;
        }
        private bool SeatWarmer = false;
        public bool getSeatWarmerStatus()
        {
            return this.SeatWarmer;
        }
        public void setSeatWarmer(bool status)
        {
            this.SeatWarmer = status;
        }
    }
}
