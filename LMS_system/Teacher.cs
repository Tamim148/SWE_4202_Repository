using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_system
{
    abstract internal class Teacher
    {
        public string teacher_name;
        public string teacher_type;

        public void set_teacher(string teacher_name,string teacher_type)
        {
            this.teacher_name = teacher_name;
            this.teacher_type = teacher_type;
        }


        public abstract double getcredit();
        List<Course> courselist = new List<Course>();

    }
}
