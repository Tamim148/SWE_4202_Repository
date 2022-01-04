using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_system
{
    internal class Student
    {
        public string Student_name;
        public string semester_student;
        public string course_code_student;

        public void set_student(string Student_name,string semester_student,string course_code_student)
        {
            this.Student_name = Student_name;
            this.semester_student = semester_student;
            this.course_code_student = course_code_student;
        }
    }
}
