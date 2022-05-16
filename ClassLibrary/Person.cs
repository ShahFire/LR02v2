using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        string Name;

        public Person(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
