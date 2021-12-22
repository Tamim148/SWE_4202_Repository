using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_mangement_system
{
    internal class Article_Class:Parent_Class
    {

        public string subject;
        public string topic;
        public void setterofArticle(string Author, string Title, int ID, string Publisher, int Quantity, string  Publication, string topic, string subject)
        {
            this.Author = Author;
            this.Title = Title;
            this.ID = ID;
            this.Publisher = Publisher;
            this.Quantity = Quantity;
            this.Publication = Publication;
            this.subject = subject;
            this.topic = topic;
            
        }



        public string getArticle()
        {
            string setbook = Convert.ToInt32(ID) + "  "+ Convert.ToInt32(Quantity)+"  " + Author + "  " + Title + "  " + Publisher + "  " + topic + "  " + Publication + "  " + subject;
            return setbook;
        }

        public bool checkArId(int checkID)
        {
            if (checkID == ID)
                return true;
            else
                return false;
        }

        public bool ReArquantityCheck()
        {
            if (Quantity == 0)
                return false;
            else return true;
        }


        public void DecreaseArtilces()
        {
            Quantity = Quantity - 1;
        }

    }
}
