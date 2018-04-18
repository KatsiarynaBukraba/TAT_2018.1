using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8.Commands
{
    /// <summary>
    /// Class of one the commands.
    /// </summary>
    public class AverageAgeCommand : ICommand
    {
        /// <summary>
        /// This method for count average age of users.
        /// </summary>
        /// <param name="list">list of users</param>
        public void Execute(List<User> list)
        {
            double result = 0.0;
            foreach (var user in list)
            {
                result = list.Average(p => p.Age);
            }

            Console.WriteLine("Average age is: {0}", result);
        }
    }
}
