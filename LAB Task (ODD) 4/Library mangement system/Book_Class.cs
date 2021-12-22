using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_mangement_system
{
    internal class Book_Class:Parent_Class
    {
        public int ISBN;
        public string Genre;
       
        
        public void setterofBook( string Author ,string Title ,int ID, string Publisher,int Quantity, string Publication ,int ISBN, string Genre )
        {
            this.Author = Author;
            this.Title = Title; 
            this.ID = ID;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
            this.Publication = Publication;
            this.ISBN = ISBN;
            this.Genre = Genre;
        }



        public string getbook()
        {
            string setbook = Convert.ToInt32(ID) + "  "+ Convert.ToInt32(Quantity)+ " " + Author + "  " + Title + "  " + Publisher + "   " + Genre + "   " +Publication + "  " + Convert.ToInt32(ISBN);
            return setbook;
        }


        public bool checkBookId(int checkID)
        {
            if (checkID == ID)
                return true;
            else
                return false;
        }
        public bool BOOKquantityCheck()
        {
            if (Quantity == 0)
                return false;
            else return true;
        }


        public void DecreaseBOOKS()
        {
            Quantity = Quantity - 1;
        }


        
    }
}
