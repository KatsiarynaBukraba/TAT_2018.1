using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class CalculateSmallestAge : ICommand
    {
        public string Execute(List<User> list)
        {
            var ages = list.Select(p => p.Age);
            var smallestAge = ages.Min();

            return smallestAge.ToString();
        }
    }
}
