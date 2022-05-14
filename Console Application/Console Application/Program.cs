using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Course managment application");
            int selection;
            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("1. Create a new group");
                Console.WriteLine("2. Show a list of groups");
                Console.WriteLine("3. Edit group info");
                Console.WriteLine("4. Show a list of students in the group");
                Console.WriteLine("5. Show a list of all students");
                Console.WriteLine("6. Create a student");
                Console.WriteLine("7. Delete the student");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
            }
            while (selection != 0);
        }
    }
}