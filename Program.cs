using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("tikva", "yosef", 1996, "tikva@gmail.com");
            User user2 = new User("keren", "haillu", 1997, "keren@gmail.com");
            User user3 = new User("yafit", "samuel", 2000, "yafit@gmail.com");
            User user4 = new User("eden", "tasama", 1991, "eden@gmail.com");
            List<User> list1 = new List<User>();
            list1.Add(user1);
            list1.Add(user2);
            list1.Add(user3);
            list1.Add(user4);

            //user1.PrintData();
            //list1.Sort();

            //foreach (User item in list1)
            //{
            //    item.PrintData();
            //}

            //Student student1 = new Student(50, "tikva", "yosef", 1996, "tikva@gmail.com");
            //student1.PrintData();
            //List<Student> list2 = new List<Student>();
            //list2.Add(student1);

            //PrintDataToFile(list1);
            //PrintToConsole();
            //PrintToFileAlon(list1);
            //PrintToConsoleUser1();

            Console.WriteLine("choose 1.add user  2.edit user  3.delete user  4.show user");
            int userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("enter first name");
                    string fn = Console.ReadLine();
                    Console.WriteLine("enter last name");
                    string ln = Console.ReadLine();
                    Console.WriteLine("enter year of birth");
                    int year = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter email");
                    string email = Console.ReadLine();

                    User user5 = new User(fn, ln, year, email);
                    list1.Add(user5);
                    PrintToFileAlon(list1);
                    break;



                case 2:

                    Edit();

                    break;

                case 3:

                    Console.WriteLine("enter first name");
                    string firstn = Console.ReadLine();

                    if (File.Exists($@"C:\files\{firstn}.txt"))
                    {
                        File.Delete($@"C:\files\{firstn}.txt");
                    }


                    break;

                case 4:
                    Console.WriteLine("enter first name");
                    string namee = Console.ReadLine();

                    PrintToConsole(list1, namee);



                    break;
            }
        }



        static void PrintDataToFile(List<User> list)
        {
            FileStream fille = new FileStream(@"C:\files\students.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fille))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    writer.WriteLine($"{list[i].FirstName} {list[i].LastName} {list[i].YearOfBirth} {list[i].Email}");
                }
            }
        }

        static void PrintToConsole(List<User> list, string name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName == name)
                {
                    FileStream file = new FileStream($@"C:\files\{list[i].FirstName}.txt", FileMode.Open);
                    using (StreamReader reader = new StreamReader(file))
                    {

                        Console.WriteLine(reader.ReadToEnd());

                    }
                }

            }
        }

        static void PrintToFileAlon(List<User> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                FileStream fille = new FileStream($@"C:\files\{list[i].FirstName}.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fille))
                {

                    writer.WriteLine($"{list[i].FirstName} {list[i].LastName} {list[i].YearOfBirth} {list[i].Email}");

                }
            }

        }

        static void PrintToConsoleUser1()
        {
            FileStream file = new FileStream(@"C:\files\tikva yosef.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        static void Edit()
        {
            Console.WriteLine("enter first name");
            string Fname = Console.ReadLine();


            FileStream file1 = new FileStream($@"C:\files\{Fname}.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(file1))
            {

                writer.WriteLine(Console.ReadLine());
            }

        }





    }
}
