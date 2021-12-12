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

        public override void PrintData()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} {this.YearOfBirth} {this.Email} {this.class_}");
        }
        
        
        

    }
}
