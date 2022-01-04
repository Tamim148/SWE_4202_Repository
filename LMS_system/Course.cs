using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_system
{
    internal class Course
    {
        public string course_code;
        public string course_type;
        public string title;
        public string semester;
        public string teacher;


        public void set_course(string course_code,string course_type,string title,string semester,string teacher)
        {
            this.course_code = course_code;
            this.course_type = course_type;
            this.title = title;
            this.semester = semester;
            this.teacher = teacher;
        }
          

        public string gettype()
        {
            return course_type;
        }
    }
}
