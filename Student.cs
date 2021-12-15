using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class Student : User
    {
        public int class_;

        public Student(int class_, string firstName, string lastName, int yearOfBirth, string email) : base(firstName, lastName, yearOfBirth, email)
        {
            this.class_ = class_;
        }

        public void PrintData()
        {
            base.PrintData(); Console.WriteLine($"{this.class_}");

        }



    }


}

