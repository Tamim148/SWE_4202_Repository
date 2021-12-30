using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_managment_system
{
    internal class Booking_Class
    {
        private string booking_id;
        private user uSer;
        private string room_choice;
        private string entry;
        private string departure;
        private int quantity;
        private string status;

        public Booking_Class()
        { }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public void setID(string booking_id)
        {
            this.booking_id = booking_id;
        }
        public  string room_choose(string room)
        {
            if (room == "Single")
            {
                return room = "Single";
            }
            else if(room =="Double")
            {
                return room = "Double";
            }
            else if(room== "Suite")
            { return room = "Suite"; }
            else
            { return room = "Delux"; }
        }
       


       

       

        public bool check_booking_id(string id)
        {
            if(booking_id==id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setOfbooking(string bookingid,string room_choice,string entry,string departure,int quantity)
        {

           
            this.booking_id = bookingid;
            this.room_choice = room_choice;
            this.entry = entry;
            this.departure = departure;
            this.quantity = quantity;

        }
        public string to_see_current_balance(string value)

        {
            return value = room_choice+"      ";
        }
    }
}
