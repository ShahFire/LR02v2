using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface Man
    {
        string GetName();
    }

    interface Job : Man
    {
        string GetJob();
    }

    interface Group : Man
    {
        string GetGroup();
    }

    interface Create : Job
    {
        Student CreateStudent(string name, string group);
        Teacher CreateTeacher(string name, TeacherPosition dolj);
    }

    interface Lecture : Job
    {
        string GiveLectures();
    }

    interface SessionFail : Group
    {
        string Failed();
    }
}
