using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person, SessionFail
    {
        string group;

        public Student(string Name, string Grup) : base(Name)
        {
            this.group = Grup;
        }

        public string GetGroup()
        {
            return group;
        }

        public string Failed()
        {
            return "Заявление на отчисление";
        }
    }
}
