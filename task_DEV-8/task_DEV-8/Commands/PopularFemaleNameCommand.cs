using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace task_DEV_8.Commands
{
    /// <summary>
    /// Class of one the commands.
    /// </summary>
    public class PopularFemaleNameCommand : ICommand
    {
        /// <summary>
        /// This method for found the most popular female surname.
        /// </summary>
        public void Execute(List<User> list)
        {
            var womans  = from user in list
                where user.Sex == false
                select user;

            int qtyMax = 0, qty;
            string result = "";  

            foreach (var woman in womans)
            {
                qty = womans.Count(p => p.FirstName.Equals(woman.FirstName));
                if (qtyMax < qty)
                {
                    qtyMax = qty;
                    result = woman.FirstName;
                }
            }

            Console.WriteLine("The most popular female name is " + result);
        }
    }
}
