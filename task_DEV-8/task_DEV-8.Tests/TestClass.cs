using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using task_DEV_8.Commands;


namespace task_DEV_8.Tests
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void AverageAgeTest()
        {
            var list = CreateList();
            var command = new AverageAgeCommand();
            command.Execute(list);
        }
        [Test]
       public void OldestUserTest()
        {
            var list = CreateList();
            var command = new OldestUserCommand();
            command.Execute(list);
        }
        [Test]
        public void FemaleNameTest()
        {
            var list = CreateList();
            var command = new PopularFemaleNameCommand();
            command.Execute(list);
        }
        [Test]
        public void EventTest()
        {
            var list = CreateList();
        }
        private List<User> CreateList()
        {
            var list = new List<User>();
            string[] file = File.ReadAllLines(@"C:\Users\Екатерина\Desktop\data.txt");

            for (int i = 0; i < file.Length; i++)
            {
                if (file[i] == "") continue;
                string[] parse = file[i].Split(' ');
                
                var user = new UserBuilder();
                user.SetFirstName(parse[0]);
                user.SetSurname(parse[1], list);
                user.SetSex(parse[2]);
                user.SetAge(parse[3]);

                list.Add(user.Build());
            }

            return list;
        }
    }
 }
