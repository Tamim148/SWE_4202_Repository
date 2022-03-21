using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LecturerRoom
    {
        private string roomName;
        private string roomNo;
        private int capacity;
        public string getRoomName()
        {
            return this.roomName;
        }
        public string getRoomNo()
        {
            return this.roomNo;
        }
        public int getCapacity()
        {
            return this.capacity;
        }
        public void setRoomName(string Name)
        {
            this.roomName = Name;
        }
        public void setRoomNo(string No)
        {
            this.roomNo = No;
        }
        public void setCapacity(int Cap)
        {
            this.capacity = Cap;
        }
    }
}
