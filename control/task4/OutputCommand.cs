using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class OutputCommand : ICommand
    {
        public string Execute(List<User> list)
        {
            foreach (User user in list)
            {
                Console.WriteLine(user);
            }

            return "done";
        }
    }
}
