using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<User> users = new List<User>();
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string path = @"G:\SWE_Repository\SWE_4202_Repository\Lab10\csv files\searchInfo.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (User user in users)
            {
                if(user.UserEmail == SearchUserEmail.Text)
                {
                    flag = true;
                    NameBar1.Text = user.UserFirstName;
                    NameBar2.Text = user.UserLastName;

                    AddressBar.Text = user.UserAddress;
                    CityBar.Text = user.UserCity;
                    CountyBar.Text = user.UserCounty;
                    StateBar.Text = user.UserState;
                    ZipBar.Text = user.UserZip;
                    Phone1Bar.Text = user.UserPhone1;
                    Phone2Bar.Text = user.UserPhone2;
                    DateTime currentDate = DateTime.Now;
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        
                        string s = "Successfully searched for "+SearchUserEmail.Text+" "+Convert.ToString(currentDate)+"\n" + user.UserFirstName + " " + user.UserLastName + "\t" + user.UserAddress + "\t" + user.UserCity + "\t" + user.UserCounty + "\t" + user.UserState + "\t" + user.UserZip + "\t" + user.UserPhone1 + "\t" + user.UserPhone2+"\n";
                        sr.WriteLine(s);
                    }
                    MessageBox.Show("User Email has been found and Updated");
                }
            }
            if(flag == false)
            {
                DateTime currentDate = DateTime.Now;
                using(StreamWriter sr = File.AppendText(path))
                {
                    string s = "Unsuccessful search for " + SearchUserEmail.Text + " " + Convert.ToString(currentDate)+"\n";
                    sr.WriteLine(s);
                }
                MessageBox.Show("User Email cannot be found");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"G:\SWE_Repository\SWE_4202_Repository\Lab10\csv files\userInfo.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    User user = new User();
                    user.UserFirstName = values[0];
                    user.UserLastName = values[1];
                    user.UserAddress = values[3];
                    user.UserCity = values[4];
                    user.UserCounty = values[5];
                    user.UserState = values[6];
                    user.UserZip = values[7];
                    user.UserPhone1 = values[8];
                    user.UserPhone2 = values[9];
                    user.UserEmail = values[10];

                    users.Add(user);
                    listBox1.Items.Add(user.UserFirstName + " " + user.UserLastName + "     " + user.UserEmail);
                }
            }
        }
    }
}
