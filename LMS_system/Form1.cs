using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_system
{
    public partial class Form1 : Form
    {
        List<Professor> professorlist = new List<Professor>();
        List<Lecturer> lecturelist = new List<Lecturer>();
        List<Student> studentlist = new List<Student>();
        List<Course> courselist = new List<Course>();
        List<Course> student_courselist = new List<Course>();
        int course_number = 0;
        double credit = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_teacher(object sender, EventArgs e)
        {
            
            string teachers_name = teacher_name_box.Text;
            string teacherstype = comboBox1.Text;
            if(teacherstype=="Lecturer")
            {
                Lecturer lecture = new Lecturer();
                lecture.set_teacher(teachers_name, teacherstype);
                lecturelist.Add(lecture);
                MessageBox.Show("Teacher's details has been added!");
                teacher_combobox.Items.Add(teachers_name);
                show_teacher_combobox.Items.Add(teachers_name);
            }
            else
            {
                Professor proff = new Professor();
                proff.set_teacher(teachers_name, teacherstype);
                professorlist.Add(proff);
                MessageBox.Show("Teacher's details has been added!");
                teacher_combobox.Items.Add(teachers_name);
                show_teacher_combobox.Items.Add(teachers_name);
            }


        }

        private void Add_course(object sender, EventArgs e)
        {
            Course course = new Course();
            string code = Course_code_box.Text;
            string type = Courese_type.Text;
            if(type=="Lab")
            {
                credit = credit + 1.5;
            }
            else
            {
                credit = credit + 3;
            }

            string course_title = course_title_txt.Text;
            string course_semester = Semester_box.Text;
            string course_teacher = teacher_combobox.Text;
            


            course.set_course(code, type, course_title, course_semester, course_teacher);
            courselist.Add(course);
            MessageBox.Show("Course's details had been added");
            semster_student.Items.Add(course_semester);
            student_course_code.Items.Add(code);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            string stu_name = student_name_txt.Text;
            string stu_sem = semster_student.Text;
            string stu_code = student_course_code.Text;

            student.set_student(stu_name, stu_sem, stu_code);
            studentlist.Add(student);
            
            MessageBox.Show("Student's details had been added");
            show_student_combobox.Items.Add(stu_name);
            course_number++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string stu_name = student_name_txt.Text;
            string stu_sem = semster_student.Text;
            string stu_code = student_course_code.Text;
            listBox1.Items.Clear();
            listBox1.Items.Add(stu_name+" is taking "+stu_code+" in the upcoming "+stu_sem);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            bool he_is_profressor = false;
            int i = 0;
            string name = show_teacher_combobox.Text;
            string teacherstype = comboBox1.Text;
            for( i=0;i<professorlist.Count;i++)
            {
                if(professorlist[i].teacher_name == name)
                {
                    he_is_profressor=true;
                    break;
                }
            }
            if(he_is_profressor)
            {
                listBox2.Items.Clear();
                if (Courese_type.Text == "Lab")
                {
                    listBox2.Items.Add(teacher_name_box.Text + "\t" + course_title_txt.Text + "\t" + Course_code_box.Text + "\t" + 1.5);
                }
                else
                {
                    listBox2.Items.Add(teacher_name_box.Text + "\t" + course_title_txt.Text + "\t" + Course_code_box.Text + "\t" + 3);

                }
            }
            else
            {
                listBox2.Items.Clear();
                listBox2.Items.Add(teacher_name_box.Text + "\t" + course_title_txt.Text + "\t" + Course_code_box.Text + "\t" + 3);
            }



        }
    }
}
