using System;

namespace Assignment4_lastedition
{
    class Program
    {
        public static void Main()
        {
            do
            {
                Welcome.Hello();
                switch ((Menu)Convert.ToInt32(Console.ReadLine()))
                {
                    case Menu.Display_game:
                        Games.Start();
                        break;
                    case Menu.Students_Information:
                        Information.Print();
                        break;
                    case Menu.Exit:
                        Exit.Goodbye();
                        break;
                    default:
                        break;
                }
            } while (true);
        }
    }
}


