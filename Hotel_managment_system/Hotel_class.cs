using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_managment_system
{
    internal class Hotel_class
    {
        static public List<user> userlist = new List<user>();
        static public List<Booking_Class> bookinlist = new List<Booking_Class>();
        
        static public int bookingId = 1;
        static public int roomNO=101;
        public string room_choose(string room)
        {
            if (room == "Single")
            {
                return room = "Single";
            }
            else if (room == "Double")
            {
                return room = "Double";
            }
            else if (room == "Suite")
            { return room = "Suite"; }
            else
            { return room = "Delux"; }
        }
       

    }
}
