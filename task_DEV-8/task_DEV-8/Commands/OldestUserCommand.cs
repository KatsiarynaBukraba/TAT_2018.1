using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_8.Commands
{
    /// <summary>
    /// Class of one the commands.
    /// </summary>
    public class OldestUserCommand : ICommand
    {
        /// <summary>
        /// This method for found the oldest user.
        /// </summary>
        /// <param name="list">list of users</param>
        public void Execute(List<User> list)
        {
            uint maxAge = 0;

            foreach (var user in list)
            {
                if (maxAge < user.Age)
                {
                     maxAge = user.Age;
                }
            }

            var result = from oldestUser in list
                where oldestUser.Age == maxAge
                select oldestUser;

            foreach (var man in result)
            {
                Console.WriteLine(man.ToString());
            }
        }
    }
}
