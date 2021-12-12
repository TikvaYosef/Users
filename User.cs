using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class User:IComparable
    {
        string firstName;
        string lastName;
        int yearOfBirth;
        string email;

        public User(string firstName, string lastName, int yearOfBirth, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.email = email;
        }
        

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public int YearOfBirth { get { return this.yearOfBirth; } set { this.yearOfBirth = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }

      public virtual void PrintData()
        {
            Console.WriteLine($"{this.FirstName} {this.LastName} {this.YearOfBirth} {this.Email}");
        }

        public int CompareTo(object obj)
        {
            User year = (User)obj;
            if (this.YearOfBirth < year.YearOfBirth)
            {
                return 1;
            }
            if (this.YearOfBirth > year.YearOfBirth)
            {
                return -1;
            }
            return 0;


        }

    }


    
    
        
    
}
