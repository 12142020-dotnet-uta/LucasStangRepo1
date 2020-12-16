using System;

namespace FirstList
{
    class Program
    {

        static string name;
        static int age;
        static void Main()
        {
            GetName();
            GetAge();
            PrintInfo();
        }
        public static string GetName()
        {                
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            return name;
        }

        public static int GetAge()
        {
            Console.WriteLine("Please enter your age: ");
            age = int.Parse(Console.ReadLine());
            
            return age;
        }

        static void PrintInfo()
        {
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);
        }
    }
}
