using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum TeacherPosition
    {
        Assistant = 0,
        StLecturer = 1
    }
    public class Teacher : Personal, Lecture
    {
        static string[] positions = new string[] { "Ассистент", "Старший преподаватель" };

        public Teacher(string Name, TeacherPosition position) : base(Name, positions[(int)position])
        {

        }

        public string GiveLectures()
        {
            return "Проести лекцию";
        }
    }
}
