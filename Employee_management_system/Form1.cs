using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_management_system
{
    public partial class Form1 : Form
    {
        List<Manager_Class> manager_s = new List<Manager_Class>();
        List<Typewriter_Class> typewriter_s = new List<Typewriter_Class>();
        List<Salesperson_Class> salesperson_s = new List<Salesperson_Class>();
        public Form1()
        {
            InitializeComponent();
        }
        double manager_id = 101;
        double typewriter_id = 201;
        double salesperson_id = 301;

        private void CreateOnClick(object sender, EventArgs e)
        {
            if (manager_radioButton.Checked)
            {
                string ID = manager_id.ToString() + Id_txt.Text;
                ++manager_id;
                string name = name_txt.Text;
                string contact = contact_txt.Text;
                string dot = date_of_joining_txt.Text;
                double salary = Convert.ToDouble(salary_txt.Text);
                double leaves = Convert.ToDouble(leaves_txt.Text);

                Manager_Class dummy = new Manager_Class();

                dummy.name = name;
                dummy.id = ID;
                dummy.salary = salary;
                dummy.contact = contact;
                dummy.DOT = dot;
                dummy.leaves = leaves;
                dummy.salary = salary;

                manager_s.Add(dummy);
                MessageBox.Show("The info of this new employee is saved!!! employee's id: "+ID);

            }
            else if (Salesperson_radioButton.Checked)
            {
                string ID = salesperson_id.ToString() + Id_txt.Text;
                ++salesperson_id;
                string name = name_txt.Text;
                string contact = contact_txt.Text;
                string dot = date_of_joining_txt.Text;
                double salary = Convert.ToDouble(salary_txt.Text);
                double leaves = Convert.ToDouble(leaves_txt.Text);

                Salesperson_Class dummy = new Salesperson_Class();

                dummy.name = name;
                dummy.id = ID;
                dummy.salary = salary;
                dummy.contact = contact;
                dummy.DOT = dot;
                dummy.leaves = leaves;
                dummy.salary = salary;

                salesperson_s.Add(dummy);
                MessageBox.Show("The info of this new employee is saved!!! employee's id: " + ID);

            }
            else if (typewriter_radioButton.Checked)
            {
                string ID = salesperson_id.ToString() + Id_txt.Text;
                ++typewriter_id;
                string name = name_txt.Text;
                string contact = contact_txt.Text;
                string dot = date_of_joining_txt.Text;
                double salary = Convert.ToDouble(salary_txt.Text);
                double leaves = Convert.ToDouble(leaves_txt.Text);

                Typewriter_Class dummy = new Typewriter_Class();

                dummy.name = name;
                dummy.id = ID;
                dummy.salary = salary;
                dummy.contact = contact;
                dummy.DOT = dot;
                dummy.leaves = leaves;
                dummy.salary = salary;

                typewriter_s.Add(dummy);
                MessageBox.Show("The info of this new employee is saved!!! employee's id: " + ID);

            }

        }

        private void CLickOnShow(object sender, EventArgs e)
        {
            string id = show_info_id_txt.Text;
            
            bool error = true;

            int i = 0;
            for (i = 0; i < manager_s.Count; i++)
            {
                if (manager_s[i].id == id)
                {
                    error = false;
                    listBox1.Items.Clear();
                    string value = manager_s[i].getter();
                    listBox1.Items.Add(value);
                    break;
                }
            }
            for (i = 0; i < typewriter_s.Count; i++)
            {
                if (typewriter_s[i].id == id)
                {
                    error = false;
                    listBox1.Items.Clear();
                    string value = typewriter_s[i].getter();
                    listBox1.Items.Add(value);
                    break;
                }
            }
            for (i = 0; i < salesperson_s.Count; i++)
            {
                if (salesperson_s[i].id == id)
                {
                    error = false;
                    listBox1.Items.Clear();
                    string value = salesperson_s[i].getter();
                    listBox1.Items.Add(value);
                    break;
                }
            }
            if (error)
            {
                throw new ApplicationException("ID not found!!");
            }


        }
        private void show_salary_on_click(object sender, EventArgs e)
        {
            string id = show_salary_id.Text;
            double years = Convert.ToDouble(year_txt.Text);
            double salary;

            bool error = true;

            int i = 0;
            for (i = 0; i < manager_s.Count; i++)
            {
                if (manager_s[i].id == id)
                {
                    error = false;
                    salary = manager_s[i].salary + years * (manager_s[i].salary * 0.15);
                    listBox2.Items.Clear();
                    string value = manager_s[i].name + " earned " + salary.ToString()+" (manager)";
                    listBox2.Items.Add(value);
                    break;
                }
            }
            for (i = 0; i < typewriter_s.Count; i++)
            {
                if (typewriter_s[i].id == id)
                {
                    error = false;
                    salary = typewriter_s[i].salary + years * (typewriter_s[i].salary * 0.1);
                    listBox2.Items.Clear();
                    string value = typewriter_s[i].name + " earned " + salary.ToString()+" (typewriter)";
                    listBox2.Items.Add(value);
                    break;
                }
            }
            for (i = 0; i < salesperson_s.Count; i++)
            {
                if (salesperson_s[i].id == id)
                {
                    error = false;
                    salary = salesperson_s[i].salary + years * (salesperson_s[i].salary * 0.05);
                    listBox2.Items.Clear();
                    string value = salesperson_s[i].name + " earned " + salary.ToString()+" (salesperson)";
                    listBox2.Items.Add(value);
                    break;
                }
            }

            if (error)
            {
                throw new ApplicationException("ID not found!!");
            }


        }

        private void edit_on_click(object sender, EventArgs e)
        {
            string id = edit_info_id_txt.Text;
            bool error = true;

            int i = 0;
            for (i = 0; i < manager_s.Count; i++)
            {
                if (manager_s[i].id == id)
                {
                    error = false;
                    manager_s[i].contact = edit_contact_txt.Text;
                    manager_s[i].DOT = DOT_edit_txt.Text;
                    manager_s[i].salary = Convert.ToDouble(edit_salary_txt.Text);
                    manager_s[i].leaves = Convert.ToDouble(leaves_edit_txt.Text);

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }
            for (i = 0; i < typewriter_s.Count; i++)
            {
                if (typewriter_s[i].id == id)
                {
                    error = false;
                    typewriter_s[i].contact = edit_contact_txt.Text;
                    typewriter_s[i].DOT = DOT_edit_txt.Text;
                    typewriter_s[i].salary = Convert.ToDouble(edit_salary_txt.Text);
                    typewriter_s[i].leaves = Convert.ToDouble(leaves_edit_txt.Text);

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }
            for (i = 0; i < salesperson_s.Count; i++)
            {
                if (salesperson_s[i].id == id)
                {
                    error = false;
                    salesperson_s[i].contact = edit_contact_txt.Text;
                    salesperson_s[i].DOT = DOT_edit_txt.Text;
                    salesperson_s[i].salary = Convert.ToDouble(edit_salary_txt.Text);
                    salesperson_s[i].leaves = Convert.ToDouble(leaves_edit_txt.Text);

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }

            if (error)
            {
                throw new ApplicationException("ID not found!!");
            }




        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddOnClick(object sender, EventArgs e)
        {
            string id = id_add_txt.Text;
            bool error = true;

            int i = 0;
            for (i = 0; i < manager_s.Count; i++)
            {
                if (manager_s[i].id == id)
                {
                    error = false;

                    manager_s[i].salary = Convert.ToDouble(salary_add_txt.Text) + manager_s[i].salary;
                    manager_s[i].leaves = Convert.ToDouble(leaves_add.Text) + manager_s[i].leaves;

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }
            for (i = 0; i < typewriter_s.Count; i++)
            {
                if (typewriter_s[i].id == id)
                {
                    error = false;

                    typewriter_s[i].salary = Convert.ToDouble(salary_add_txt.Text) + typewriter_s[i].salary;
                    typewriter_s[i].leaves = Convert.ToDouble(leaves_add.Text) + typewriter_s[i].leaves;

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }
            for (i = 0; i < salesperson_s.Count; i++)
            {
                if (salesperson_s[i].id == id)
                {
                    error = false;

                    salesperson_s[i].salary = Convert.ToDouble(salary_add_txt.Text) + salesperson_s[i].salary;
                    salesperson_s[i].leaves = Convert.ToDouble(leaves_add.Text) + salesperson_s[i].leaves;

                    MessageBox.Show("New information for the following person is saved !!");

                    break;
                }
            }
            if (error)
            {
                throw new ApplicationException("ID not found!!");
            }


        }
    }
}
