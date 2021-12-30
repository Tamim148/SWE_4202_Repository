using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_managment_system
{
    public partial class Form1 : Form
    {
            user dummy_user = new user();
         
        public double give_me_price(string room)
        {
            if (room == "Single")
            {
                return 50;
            }
            else if (room == "Double")
            {
                return 100;
            }
            else if (room == "Suite")
            { return 200; }
            else
            { return 250; }
        }

         Booking_Class temp_booking = new Booking_Class();
        public double amount()
        {
            DateTime start_time=Convert.ToDateTime(dateTimePicker1.Text);
            DateTime end_time = Convert.ToDateTime(dateTimePicker2.Text);
            double dAYS = (end_time - start_time).Days;
            return give_me_price(room_choice_txt.Text) * Convert.ToDouble(comboBox3.Text)*dAYS;
        }

       


        double bookingID = 0;
        double room_number = 101;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void see_order_on_click(object sender, EventArgs e)
        {
            string bookng_check_id = checkbookidtxt.Text;
            int i = 0;
            bool id_exits = false;



            for (i = 0; i < Hotel_class.bookinlist.Count; i++)
            {
                if (Hotel_class.bookinlist[i].check_booking_id(checkbookidtxt.Text))
                {
                    id_exits=true;
                    break;
                }
            }

            if (id_exits)
            {
                statustxt.Text = owners_section.Text;
                room_no_txt.Text = room_number.ToString();
                amounttxt.Text = amount().ToString();
                name_txt.Text =usernametxt.Text;
                address_txt.Text=useraddresstxt.Text;

            }

            else
            {
                MessageBox.Show("Invalid input!!");
            }

        }

        private void booking_on_click(object sender, EventArgs e)
        {
            string bookser_id = booking_user_id.Text;
            string booking_room = room_choice_txt.Text;
            string entry_date = dateTimePicker1.Text;
            string departation = dateTimePicker2.Text;
            int quantity = Convert.ToInt32(comboBox3.Text);

            bool errorExists = true;

            for(int i=0;i<Hotel_class.userlist.Count;i++)
            {
                if(Hotel_class.userlist[i].checkifUserExist(bookser_id))
                {
                    errorExists = false;
                    break;
                }
            }


            if(!errorExists)
            {
                temp_booking.setOfbooking(bookingID.ToString(), booking_room, entry_date, departation, quantity);
                MessageBox.Show("Room has been booked !!\nRoom ID is " + bookingID.ToString() + "\nYour room number is" + room_number.ToString());
                ++bookingID;
                room_number++;
                Hotel_class.bookinlist.Add(temp_booking);
                
            }
            else
            {
                MessageBox.Show("Invalid input!!");

            }

        }

        private void create_an_account(object sender, EventArgs e)
        {
            string user_id = useridtxt.Text;
            string user_name = usernametxt.Text;
            string user_phone = userphonetxt.Text;
            string user_address = useraddresstxt.Text;


            dummy_user.setuser(user_id, user_name, user_phone, user_address);
            Hotel_class.userlist.Add(dummy_user);
            MessageBox.Show("ALL the details of user saved!!");



        }

        private void click_on_status(object sender, EventArgs e)
        {
            string bookng_check_id = bookingidtxt.Text;
            int i = 0;
          
           

            
                for (i = 0; i < Hotel_class.bookinlist.Count; i++)
                {
                    if (Hotel_class.bookinlist[i].check_booking_id(bookingidtxt.Text))
                    {
                        
                        break;
                    }
                }
            if(Hotel_class.bookinlist[i].check_booking_id(bookingidtxt.Text))
            {

                
                MessageBox.Show("Status has been updated!!");

                    }
            else
            {
                MessageBox.Show("Invalid Input");
            }
            
        }

        private void owners_section_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

           
                
                listBox1.Items.Add(room_choice_txt.Text+"           "+room_number.ToString()+"           "+amount());

            string bookng_check_id = checkbookidtxt.Text;
            int i = 0;
            bool id_exits = false;



            for (i = 0; i < Hotel_class.bookinlist.Count; i++)
            {
                if (Hotel_class.bookinlist[i].check_booking_id(checkbookidtxt.Text))
                {
                    id_exits = true;
                    break;
                }
            }

            if (id_exits)
            {
                listBox1.Items.Add(room_choice_txt.Text + "           " + room_number.ToString() + "           " + amount());
                listBox1.Items.Clear();
            }

            else
            {
                MessageBox.Show("Invalid input!!");
            }


        }

        private void room_no_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
