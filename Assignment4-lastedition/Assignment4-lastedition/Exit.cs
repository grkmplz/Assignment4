using System;

namespace Assignment4_lastedition
{
    class Exit
    {
        public static void Goodbye()
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to quit? [y/n]");

            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                Console.WriteLine("Thank you for your attention , see yeah !");
                Environment.Exit(0);
            }
        }
    }
}