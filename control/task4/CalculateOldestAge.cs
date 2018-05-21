using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class CalculateOldestAge : ICommand
    {
        public string Execute(List<User> list)
        {
            var ages = list.Select(p => p.Age);
            var oldestAge = ages.Max();

            return oldestAge.ToString();
        }
    }
}
