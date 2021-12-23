using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Sysytem
{
    public partial class Form1 : Form
    {
        List<CAR_CLASS> carlist=new List<CAR_CLASS>();
        List<USER_CLASS> userlist=new List<USER_CLASS>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SAVE_CAR_on_CLICK(object sender, EventArgs e)
        {
            CAR_CLASS car = new CAR_CLASS();
            string car_model=modeltxt.Text;
            string car_name = carnametxt.Text;
            string car_manufacturer=manufacturertxt.Text;
            string car_YOM=YOMtxt.Text;
            int car_num = Convert.ToInt32(carnumbertxt.Text);

            car.setterofCar(car_model, car_name, car_manufacturer,car_YOM,car_num);
            carlist.Add(car);

            MessageBox.Show("ALL the car's details is saved!!");

        }



        private void SAVE_user_on_click(object sender, EventArgs e)
        {
            USER_CLASS user = new USER_CLASS(); 
            string user_name=usernametxt.Text;
            int user_ID=Convert.ToInt32(idtxt.Text);
            string user_address=addresstxt.Text;
            string user_destination=destinationtxt.Text;
            string user_phone=phonenumtxt.Text;

            user.setterofUSER(user_name,user_ID,user_address,user_phone,user_destination);
            userlist.Add(user);
            MessageBox.Show("ALL the user's details is saved!!");

        }

        private void RENT_ON_click(object sender, EventArgs e)
        {
            string car_Checkid = rentmodeltxt.Text;

            bool carexits = false;
            bool quantityexists = false;

            int i = 0;
            for (i = 0; i < carlist.Count; i++)
            {
                if (carlist[i].checkMODEL(car_Checkid))
                {
                    carexits = true;
                    if (carlist[i].checknumber() == true)
                    {
                        quantityexists = true;
                    }
                    break;
                }

            }

            if (carexits == true && quantityexists == true)
            {
                carlist[i].Decreasecars();
                MessageBox.Show("Your car rent is complete!!");

            }
            else
            {
                if (carexits == false)
                {
                    MessageBox.Show("Invalid Input!!");
                }
                if (quantityexists == false)
                {
                    MessageBox.Show("Insufficient CARS!!");
                }
            }


        }

        private void SHOW_CAR(object sender, EventArgs e)
        {

            bool car_exits = false;
            string car_model_check = showmodtxt.Text; 


            int i = 0;
            for (i = 0; i < carlist.Count; i++)
            {
                if (carlist[i].checkMODEL(car_model_check))
                {
                    car_exits = true;

                    break;
                }

            }

            if (car_exits == true)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(carlist[i].getCAR());
            }
            else
            {
                MessageBox.Show("Invalid input!!");
            }



        }

        private void SHOW_user(object sender, EventArgs e)
        {

            bool user_exits = false;
            string user_id_check = historyidtxt.Text;


            int i = 0;
            for (i = 0; i < userlist.Count; i++)
            {
                if (userlist[i].checkID(user_id_check))
                {
                    user_exits = true;

                    break;
                }

            }

            if (user_exits == true)
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(userlist[i].getterofUser());
            }
            else
            {
                MessageBox.Show("Invalid input!!");
            }



        }
    }
}
