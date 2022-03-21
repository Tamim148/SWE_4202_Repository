using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LecturerRoom Lecture = new LecturerRoom();
            Lab lab = new Lab();
            Lecture.setRoomName("Pera");
            Lecture.setRoomNo("Nai");
            Lecture.setCapacity(64177);
            lab.setCapacity(80085);
            lab.setLabName("Murgi");

            Lab lab2 = new Lab();
            lab2.setCapacity(800845);
            lab2.setLabName("Morog");

            LecturerRoom Lecture2 = new LecturerRoom();
            Lecture2.setRoomName("Onk");
            Lecture2.setRoomNo("Pera");
            Lecture2.setCapacity(121);
            N28Building building = new N28Building();
            building.LectRoom.Add(Lecture);
            building.LabRoom.Add(lab);
            building.LabRoom.Add(lab2);
            building.LectRoom.Add(Lecture2);
            building.showAllLecturerRoom();
            building.showAllLab();
            Console.ReadKey();

        }
    }
}
