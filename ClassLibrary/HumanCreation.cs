using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HumanCreation : Personal, Create
    {
        public HumanCreation(string name) : base(name, "Кадровик")
        {

        }

        public Student CreateStudent(string StudentName, string group)
        {
            return new Student(StudentName, group);
        }

        public Teacher CreateTeacher(string TeacherName, TeacherPosition position)
        {
            return new Teacher(TeacherName, position);
        }
    }
}
