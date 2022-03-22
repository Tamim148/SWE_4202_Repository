using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_final
{
    internal class StudentClass
    {
        public string id;
      
        public string attendence="0";
        public string name;
        public string quiz1= "0";
        public string q2= "0";
        public string q3= "0";
        public string q4= "0";
        public string viva= "0";
        public string mid= "0";
        public string final= "0";

        public double get_total_quiz(double quiz1, double q2, double q3, double q4)
        {
            if (quiz1 >= q4 && q2 >= q4 && q3 >= q4)
            {
                return quiz1 + q2 + q3;
            }
            else if (quiz1 >= q2 && q4 >= q2 && q3 >= q2)
            {
                return quiz1 + q4 + q3;
            }
            else if (quiz1 >= q3 && q4 >= q3 && q2 >= q3)
            {
                return quiz1 + q4 + q2;
            }
            else
            {
                return q2 + q3 + q4;
            }

        }


        public double total_marks(double final, double mid, double attendence, double total_quiz, double viva )
        {
            return final + mid + attendence + total_quiz+viva;
        }


        public double percentage(double total)
        {
            return total / 300.00;
        }

        public string grade(double percentage)
        {
            if (percentage <= 100 && percentage >= 81)
            {
                return "A+";
            }
            else if (percentage <= 80 && percentage >= 75)
            {
                return "A";
            }
            else if (percentage <= 74 && percentage >= 71)
            {
                return "A-";
            }
            else if (percentage <= 70 && percentage >= 65)
            {
                return "B+";
            }
            else if (percentage <= 64 && percentage >= 61)
            {
                return "B-";
            }
            else if (percentage <= 60 && percentage >= 55)
            {
                return "C+";
            }
            else if (percentage <= 54 && percentage >= 51)
            {
                return "C";
            }
            else if (percentage <= 50 && percentage >= 45)
            {
                return "D";
            }
            else
            {
                return "F";
            }


        }

    }



}
