using System;


namespace Project2
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int toStoIDvaiset = 120 - userInput;
            Console.WriteLine(toStoIDvaiset);
        }
    }
}
