using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<StudentClass> students = new List<StudentClass>();

        private void clickOnserch(object sender, EventArgs e)
        {
            bool flag = false;

            foreach (StudentClass studnt in students)
            {
                if (studnt.id == IDtextBox.Text)
                {
                    flag = true;
                    attendenacetxt.Text = studnt.attendence;
                    quiz1txt.Text = studnt.quiz1;
                    quiz2txt.Text = studnt.q2;
                    quiz3txt.Text = studnt.q3;
                    quiz4txt.Text = studnt.q4;
                    double quiz1 = Convert.ToDouble(quiz1txt.Text);
                    double q2 = Convert.ToDouble(quiz2txt.Text);
                    double q3 = Convert.ToDouble(quiz3txt.Text);
                    double q4 = Convert.ToDouble(quiz4txt.Text);
                    double final = Convert.ToDouble(finaltxt.Text);
                    double mid = Convert.ToDouble(midtxt.Text);
                    double viva = Convert.ToDouble(vivatxt.Text);
                    double attendence = Convert.ToDouble(attendenacetxt.Text);
                    quiztotal.Text = Convert.ToString(studnt.get_total_quiz(quiz1, q2, q3, q4));
                    double total_quiz = Convert.ToDouble(quiztotal.Text);

                    midtxt.Text = Convert.ToString(studnt.mid);
                    finaltxt.Text = Convert.ToString(studnt.final);
                    vivatxt.Text = Convert.ToString(studnt.viva);
                    totaltxt.Text = Convert.ToString(studnt.total_marks(final, mid, attendence, total_quiz, viva));
                    double value = Convert.ToDouble(totaltxt.Text);
                    percentagetxt.Text = Convert.ToString(studnt.percentage(value));
                    double percentage = Convert.ToDouble(percentagetxt.Text);
                    gradetxt.Text = Convert.ToString(studnt.grade(percentage));

                }
            }
            if (flag == false)
            {

                MessageBox.Show("Student  cannot be found");
            }

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
           string path = @"E:\SWE4201MarkSheet.csv";
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    StudentClass student = new StudentClass();
                    student.id = values[0];
                    student.name = values[1];
                    if (values[2] !="")
                    {
                        student.attendence =values[2];
                    }
                    if (values[3] != "")
                    {

                        student.quiz1 = values[3];
                    }
                    if (values[4] != "")
                    {
                        student.q2 = values[4];
                    }
                    if (values[5] != "")
                    {
                    student.q3 = values[5];

                    }
                    if (values[6] != "")
                    {

                        student.q4 = values[6];
                    }
                    if (values[7] != "")
                    {

                        student.mid = values[7];
                    }
                    if (values[8] != "")
                    {

                        student.final = values[8];
                    }
                    if (values[9] != "")
                    {

                    student.viva = values[9];
                    }

                    students.Add(student);
                    listBox.Items.Add(student.id + "        " + student.name + "        " );
                }
            }
        }
    }
}
