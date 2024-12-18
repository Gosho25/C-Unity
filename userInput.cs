using System;


namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your born year: ");
            short bYear = short.Parse(Console.ReadLine());

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age are: " + age);
            Console.WriteLine("Your born year is: " + bYear);
        }
    }
}
