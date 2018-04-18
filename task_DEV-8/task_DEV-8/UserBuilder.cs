using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_8
{
    public class UserBuilder
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

                foreach (var sn in list)
                {
                    if (sn.Surname.Equals(surname))
                    {
                        var args = new Namesake();
                        GetMessage(args);
                    }
                }

            user.Surname = surname;
        }

        public void SetAge(string age)
        {
            user.Age  = UInt32.Parse(age);
        }

        public void SetSex(string sex)
        {
            if (sex != "man" && sex != "woman")
            {
                throw new ArgumentException();
            }

            if (sex == "man") user.Sex = true;
            else user.Sex = false;
        }

        public User Build()
        {
            return user;
        }

        protected virtual void GetMessage(Namesake e)
        {
            EventHandler<Namesake> handler = Message;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<Namesake> Message;
    }
}
