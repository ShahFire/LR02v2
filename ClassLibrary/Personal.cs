using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Personal : Person
    {
        string Position;

        public Personal(string name, string dolj) : base(name)
        {
            this.Position = dolj;
        }

        public string GetJob()
        {
            return Position;
        }
    }
}
