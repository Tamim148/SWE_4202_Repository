using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class N28Building
    {
        public List<LecturerRoom> LectRoom = new List<LecturerRoom>();
        public List<Lab> LabRoom = new List<Lab>();

        public void showAllLab()
        {
            foreach (Lab labs in LabRoom)
            {
                string LabInfo = labs.getLabName() + "\t" + Convert.ToString(labs.getCapacity() + "\n");
                Console.WriteLine(LabInfo);
            }
        }
        public void showAllLecturerRoom()
        {
            foreach (LecturerRoom lect in LectRoom)
            {
                string LectInfo = lect.getRoomName() + "\t" + lect.getRoomNo() + "\t" + Convert.ToString(lect.getCapacity() + "\n");
                Console.WriteLine (LectInfo);
            }
        }
    }
}
