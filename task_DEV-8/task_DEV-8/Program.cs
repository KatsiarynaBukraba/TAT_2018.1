using System;
using System.Collections.Generic;
using System.IO;
using task_DEV_8.Commands;

namespace task_DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var users = new List<User>();
                var input = new UserBuilder();
                input.Message += GetNamesake;

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

                    Console.WriteLine("\n4) Input the sex:");
                    user.SetSex(Console.ReadLine());

                    users.Add(user.Build());

                    Console.WriteLine("\nFor continue input press a");
                } while (Console.ReadKey(true).KeyChar == 'a');

                var invoker = new InvokerCommand();
                invoker.SetCommand(new AverageAgeCommand());
                invoker.ExecuteCommand(users);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetNamesake(object sender, Namesake e)
        {
            Console.WriteLine("Namesake");
        }
    }
}
