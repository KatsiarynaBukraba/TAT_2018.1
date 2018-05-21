using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class UserBuilder
    {
        private User user;

        public UserBuilder()
        {
            user = new User();
        }

        public void SetFirstName(string name)
        {
            if (name.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            user.FirstName = name;
        }

        public void SetSurname(string surname, List<User> list)
        {
            if (surname.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            user.Surname = surname;
        }

        public void SetAge(string age)
        {
            user.Age = UInt32.Parse(age);
        }

        public User Build()
        {
            return user;
        }
    }
}
