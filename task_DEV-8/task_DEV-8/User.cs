using System;

namespace task_DEV_8
{
    public struct User
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        /// <summary>
        /// If Sex = 1 it's man, Sex = 0 - woman.  
        /// </summary>
        public bool Sex { get; set; }
        public uint Age { get; set; }

        public override string ToString()
        {
            return FirstName + " " + Surname + " " + Age + " " + Sex;
        }
    }
}
