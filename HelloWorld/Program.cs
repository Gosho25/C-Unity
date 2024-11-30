using System;


namespace WhriteTextToFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            string message = "hello";
            int count = 0;

            while (true)
            {
                Console.WriteLine(message);
                count++;
                if(count > 9)
                {
                    break;
                }
            }
            */
            for (int i = 0; i < 100; i += 3)
            {
                // Don't change above this line

                if (i > 21)
                {
                    break;
                }
    
            // Don't change below this line
                Console.WriteLine(i);
            }


        }
    }
}