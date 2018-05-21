using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    interface ICommand
    {
       string Execute(List<User> list);
    }
}
