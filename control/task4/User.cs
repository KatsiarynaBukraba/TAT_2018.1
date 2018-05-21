using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return Surname + " " + FirstName  + " " + Age;
        }
    }
}
