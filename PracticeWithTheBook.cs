namespace PracticeWithTheBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toFive = int.Parse(Console.ReadLine());//random
            switch(toFive)//with every type: int, float, string ...
            {
                case 1:
                    Console.WriteLine("Your number is 1");
                    break;
                case 2:
                    Console.WriteLine("Your number is 2");
                    break;
                case 3:
                    Console.WriteLine("Your number is 3");
                    break;
                case 4:
                    Console.WriteLine("Your number is 4");
                    break;
                case 5:
                    Console.WriteLine("Your number is 5");
                    break;
                default:
                    Console.WriteLine("Your number is 0 or something else");
                    break;

            }
            Math.Pow(2, toFive);//To check the Math class
        }
    }
}
