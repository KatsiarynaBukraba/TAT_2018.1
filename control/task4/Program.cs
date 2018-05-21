using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var users = new List<User>();
                var input = new UserBuilder();

                do
                {
                    var user = new UserBuilder();
                    Console.WriteLine("\nInput the information about user.");

                    Console.WriteLine("\n1) Input the first name:");
                    user.SetFirstName(Console.ReadLine());

                    Console.WriteLine("\n2) Input the surname:");
                    user.SetSurname((Console.ReadLine()), users);

                    Console.WriteLine("\n3) Input the age:");
                    user.SetAge(Console.ReadLine());

                    users.Add(user.Build());

                    Console.WriteLine("\nFor continue input press a");
                } while (Console.ReadKey(true).KeyChar == 'a');

                do
                {
                    chooseCommand:

                    Console.WriteLine("\nChoose command:" +
                    "\n1) Calculate the smallest age;" +
                    "\n2) Calculate the oldest age;" +
                    "\n3) Calculate the middle age;" +
                    "\n4) Output all users;" +
                    "\n5) Exit." +);

                    var number = Console.ReadLine();

                    Invoker invoker = new Invoker();

                    switch (number)
                    {
                        case "1":
                            invoker.SetCommand(new CalculateSmallestAge());
                            break;
                        case "2":
                            invoker.SetCommand(new CalculateOldestAge());
                            break;
                        case "3":
                            invoker.SetCommand(new CalculateMiddleAge());
                            break;
                        case "4":
                            invoker.SetCommand(new OutputCommand());
                            break;
                        case "5":
                            return;
                        default:
                            goto chooseCommand;
                    }

                    invoker.ExecuteCommand(users);
                }
                while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
