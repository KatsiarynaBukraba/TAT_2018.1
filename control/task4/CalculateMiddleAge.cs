using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class CalculateMiddleAge : ICommand
    { 
        public string Execute(List<User> list)
        {
            var ages = list.Select(p => p.Age);
            double middleAge = 0;

            foreach (uint i in ages)
            {
                middleAge += i;
            }

            middleAge = middleAge / ages.Count();

            middleAge = (int)middleAge * 100;
            middleAge = middleAge / 100;

            return middleAge.ToString();
        }
    }
}
