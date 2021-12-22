using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_mangement_system
{
    public partial class Form1 : Form
    {
        List <Book_Class> booklist =new List<Book_Class>();
        List <Article_Class> articlelist =new List<Article_Class>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_BOOK_ONCLICK(object sender, EventArgs e)
        {
             Book_Class book = new Book_Class();

              string bookAuthor=Bookau.Text;
              string Title=Bookname.Text;
              int BOokID=Convert.ToInt32(BookID.Text);
              string BOokPublisher=Bookpub.Text;
              int BOokQuantity=Convert.ToInt32(Bookqu.Text);
              string BOokPublication=bookPUBLI.Text;

             int isbn_book=Convert.ToInt32(book_isbn.Text);
             string genre_book = genretxt.Text;


             book.setterofBook(bookAuthor, Title, BOokID, BOokPublisher, BOokQuantity, BOokPublication, isbn_book, genre_book);
              booklist.Add(book);

            MessageBox.Show("Book has been saved!");


        }

        private void ADD_ARTICLE_ON_CLICK(object sender, EventArgs e)
        {
            Article_Class article = new Article_Class();

            string ar_Author = ar_au.Text;
            string ar_Title = ar_name.Text;
            int ar_id = Convert.ToInt32(ar_ID.Text);
            string ar_Publis = ar_Publisher.Text;
            int ar_Quantity = Convert.ToInt32(ar_quan.Text);
            string ar_Publication = ar_publictaion.Text;

            string topic_ar = topictxt.Text;
            string subject_ar = ar_subject.Text;


            article.setterofArticle(ar_Author, ar_Title, ar_id, ar_Publis,ar_Quantity, ar_Publication, topic_ar, subject_ar);
            articlelist.Add(article);

            MessageBox.Show("Article has been saved!");

        }

        private void BORROW_BOOK(object sender, EventArgs e)
        {

            int book_Checkid=Convert.ToInt32(BookID.Text);

            bool bookexits = false;
            bool quantityexists = false;

            int i = 0;
            for(i=0;i<booklist.Count;i++)
            {
                if(booklist[i].checkBookId(book_Checkid))
                {
                    bookexits = true;
                    if(booklist[i].BOOKquantityCheck()==true)
                    {
                        quantityexists = true;
                    }
                    break;
                }

            }

            if(bookexits==true && quantityexists==true)
            {
                booklist[i].DecreaseBOOKS();
                MessageBox.Show("Book has been borrowed!!");

            }
            else
            {
                if(bookexits==false)
                {
                    MessageBox.Show("Invalid Input!!");
                }
                if (quantityexists == false)
                {
                    MessageBox.Show("Insufficient Books!!");
                }
            }


        }

        private void BORROW_ARTICLE(object sender, EventArgs e)
        {

            int arti_Checkid = Convert.ToInt32(ar_ID.Text);

            bool ar_exits = false;
            bool ar_quan_exists = false;

            int i = 0;
            for (i = 0; i < articlelist.Count; i++)
            {
                if (articlelist[i].checkArId(arti_Checkid))
                {
                    ar_exits = true;
                    if (articlelist[i].ReArquantityCheck() == true)
                    {
                        ar_quan_exists = true;
                    }
                    break;
                }

            }

            if (ar_exits == true && ar_quan_exists == true)
            {
                articlelist[i].DecreaseArtilces();
                MessageBox.Show("Article has been borrowed!!");

            }
            else
            {
                if (ar_exits == false)
                {
                    MessageBox.Show("Invalid Input!!");
                }
                if (ar_quan_exists == false)
                {
                    MessageBox.Show("Insufficient Articles!!");
                }
            }
        }

        private void SHOW_BOOK(object sender, EventArgs e)
        {
            int book_Checkid = Convert.ToInt32(BookID.Text);

            bool bookexits = false;
            

            int i = 0;
            for (i = 0; i < booklist.Count; i++)
            {



                listBox1.Items.Add(booklist[i].getbook());

            }
        }

        private void SHOW_Article(object sender, EventArgs e)
        {

            int arti_Checkid = Convert.ToInt32(ar_ID.Text);

            bool ar_exits = false;
       

            int i = 0;
            for (i = 0; i < articlelist.Count; i++)
            {
                if (articlelist[i].checkArId(arti_Checkid))
                {
                    ar_exits = true;
                  
                    break;
                }

            }

            if (ar_exits == true)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(articlelist[i].getArticle());
            }
            else
            {
                MessageBox.Show("Invalid input!!");
            }


        }
    }
}
