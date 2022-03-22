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

namespace LabFinalTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        
        private void label12_Click(object sender, EventArgs e)
        {

        }
        public double quizSumCalculator(string QuizI, string QuizII, string QuizIII, string QuizIV)
        {
            double quiz1 = Convert.ToDouble(QuizI);
            double quiz2 = Convert.ToDouble(QuizII);
            double quiz3 = Convert.ToDouble(QuizIII);
            double quiz4 = Convert.ToDouble(QuizIV);
            double[] quizMark = { quiz1, quiz2, quiz3, quiz4 };
            Array.Sort(quizMark);
            double quizTotal = quizMark[1] + quizMark[2] + quizMark[3];
            return quizTotal;
        }
        public double totalMarkCalculator(string AttendMark,double quizTotal,string MidMark,string FinalMark,string VivaMark)
        {
            double attendance = Convert.ToDouble(AttendMark);
            double midMark = Convert.ToDouble(MidMark);
            double finalMark = Convert.ToDouble(FinalMark);
            double vivaMark = Convert.ToDouble(VivaMark);
            double TotalMark = attendance + quizTotal + midMark + finalMark +vivaMark;
            return TotalMark;
        }
        public double percentageCalculator (double totalMark)
        {
            double percentage = (totalMark * 100) / 300;
            return percentage;
        }
        public string GradeCalculator (double result)
        {
            string grade;
            if (result >= 80 && result <= 100)
            { 
                grade = "A+";
            }
            else if (result >= 75 && result < 80)
            { 
                grade = "A";
            }
            else if (result >= 70 && result < 75)
            { 
                grade = "A-";
            }
            else if (result >= 65 && result < 70)
            { 
                grade = "B+";
            }
            else if (result >= 60 && result < 65)
            { 
                grade = "B";
            }
            else if (result >= 55 && result < 60)
            { 
                grade = "B-"; 
            }
            else if (result >= 50 && result < 55)
            { 
                grade = "C+"; 
            }
            else if (result >= 45 && result < 50)
            {
                grade = "C"; 
            }
            else if (result >= 40 && result < 45)
            { 
                grade = "D"; 
            }
            else if (result >= 0 && result < 40)
            {
                grade = "F"; 
            }
            else { 
                grade = "Illegal grade"; 
            }
            
            return grade;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"G:\lab_final_completed\lab_final_(Linq used)\SWE4201MarkSheet.csv";
            using (var reader = new StreamReader(path))
            {
                InformationDisplayListBox.Items.Add("ID \t\t Name\t\t\tpercentage\tGrade");
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Student std = new Student();
                    std.ID = values[0];
                    std.Name = values[1];
                    if (values[2] != "")
                    {
                        std.Attendance = values[2];
                    }
                    if (values[3] != "")
                    {
                        std.QuizI = values[3];
                    }
                    if (values[4] != "")
                    {
                        std.QuizII = values[4];
                    }
                    if (values[5] != "")
                    {
                        std.QuizIII = values[5];
                    }
                    if (values[6] != "")
                    {
                        std.QuizIV = values[6];
                    }
                    if (values[7] != "")
                    {
                        std.Mid = values[7];
                    }
                    if (values[8] != "")
                        std.Final = values[8];
                    if (values[9] != "")
                    {
                        std.Viva = values[9];
                    }
                    if (std.ID != "ID")
                    {
                        double quizSum = quizSumCalculator(std.QuizI, std.QuizII, std.QuizIII, std.QuizIV);
                        double totalMark = totalMarkCalculator(std.Attendance, quizSum, std.Mid, std.Final, std.Viva);
                        double percentage = percentageCalculator(totalMark);
                        string grade = GradeCalculator(percentage);

                        std.Total = Convert.ToString(totalMark);
                        std.QuizTotal = Convert.ToString(quizSum);
                        std.Percentage = Convert.ToString(percentage);
                        std.Grade = grade;

                        students.Add(std);


                        InformationDisplayListBox.Items.Add(std.ID + "\t" + std.Name + "\t\t" + std.Percentage + "%" + "\t\t" + std.Grade);
                    }
                    }
                }
        }

        private void SearchByIDButton_Click(object sender, EventArgs e)
        {
            string searchID = SearchIDTextBox.Text;
            
            bool flag = false;
            var List = from std in students 
                       where std.ID == searchID 
                       select std;
            foreach(var std in List)
            {
                AttendanceMarkLabel.Text = std.Attendance;
                QuizIMarkLabel.Text = std.QuizI;
                QuizIIMarkLabel.Text = std.QuizII;
                QuizIIIMarkLabel.Text = std.QuizIII;
                QuizIVMarkLabel.Text = std.QuizIV;
                QuizBestThreeSum.Text = std.QuizTotal;
                MidMarkLabel.Text = std.Mid;
                FinalMarkLabel.Text = std.Final;
                VivaMarkLabel.Text = std.Viva;
                TotalMarkLabel.Text = std.Total;
                PercentageMarkLabel.Text = std.Percentage + "%";
                GradeLabel.Text = std.Grade;
                flag = true;
                MessageBox.Show("Student Info has been Updated");
            }
            if(flag==false)
            {
                MessageBox.Show("Student ID is not found ");
                return;
            }

        }
    }
}
