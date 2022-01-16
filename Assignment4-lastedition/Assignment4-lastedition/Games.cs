using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4_lastedition
{
    class Games
    {

        private static char[] tables = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        public static void Start()
        {
            do
            {
                int ince = 0;
                char firstvalue = 'X';
                Console.Clear();
                Console.WriteLine("First user is -X- , Second user is -0-");
                Console.WriteLine("welcome TictacToe");
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i] = ' ';
                }
                bool keldon = true;
                do
                {
                    Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                             tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                             tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");

                    bool sameornot = true;
                    do
                    {
                        Console.Write(firstvalue + "'s move > ");
                        string read = Console.ReadLine();
                        if (read != "")
                        {
                            if (read == "1")
                            {
                                if (tables[0] == ' ')
                                {
                                    tables[0] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "2")
                            {
                                if (tables[1] == ' ')
                                {
                                    tables[1] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "3")
                            {
                                if (tables[2] == ' ')
                                {
                                    tables[2] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "4")
                            {
                                if (tables[3] == ' ')
                                {
                                    tables[3] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "5")
                            {
                                if (tables[4] == ' ')
                                {
                                    tables[4] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "6")
                            {
                                if (tables[5] == ' ')
                                {
                                    tables[5] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "7")
                            {
                                if (tables[6] == ' ')
                                {
                                    tables[6] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "8")
                            {
                                if (tables[7] == ' ')
                                {
                                    tables[7] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                            else if (read == "9")
                            {
                                if (tables[8] == ' ')
                                {
                                    tables[8] = firstvalue;
                                    sameornot = false;
                                    break;
                                }
                            }
                        }

                        if (sameornot)
                        {
                            Console.WriteLine("illegal move! try again");
                        }
                    } while (sameornot);
                    ince++;
                    if (tables[0] == 'X' || tables[0] == 'O' && tables[1] == 'X' || tables[1] == 'O' && tables[2] == 'X' || tables[2] == 'O')
                    {
                        if (tables[0] == tables[1] && tables[1] == tables[2] && tables[0] == tables[2])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if ((tables[0] == 'X' || tables[0] == 'O') && (tables[1] == 'X' || tables[1] == 'O') && (tables[2] == 'X' || tables[2] == 'O') && (tables[3] == 'X' || tables[3] == 'O') && (tables[4] == 'X' || tables[4] == 'O') && (tables[5] == 'X' || tables[5] == 'O') && (tables[6] == 'X' || tables[6] == 'O') && (tables[7] == 'X' || tables[7] == 'O') && (tables[8] == 'X' || tables[8] == 'O'))
                    {
                        if ((tables[0] == 'X' || tables[0] == 'O') && (tables[1] == 'X' || tables[1] == 'O') && (tables[2] == 'X' || tables[2] == 'O') && (tables[3] == 'X' || tables[3] == 'O') && (tables[4] == 'X' || tables[4] == 'O') && (tables[5] == 'X' || tables[5] == 'O') && (tables[6] == 'X' || tables[6] == 'O') && (tables[7] == 'X' || tables[7] == 'O') && (tables[8] == 'X' || tables[8] == 'O'))
                        {
                            Console.WriteLine("Game is draw ! = Equal ! ");
                            break;
                        }

                    }
                    if (tables[0] == 'X' || tables[0] == 'O' && tables[3] == 'X' || tables[3] == 'O' && tables[6] == 'X' || tables[6] == 'O')
                    {
                        if (tables[0] == tables[3] && tables[3] == tables[6] && tables[0] == tables[6])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[3] == 'X' || tables[3] == 'O' && tables[4] == 'X' || tables[4] == 'O' && tables[5] == 'X' || tables[5] == 'O')
                    {
                        if (tables[3] == tables[4] && tables[4] == tables[5] && tables[3] == tables[5])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[6] == 'X' || tables[6] == 'O' && tables[7] == 'X' || tables[7] == 'O' && tables[8] == 'X' || tables[8] == 'O')
                    {
                        if (tables[6] == tables[7] && tables[7] == tables[8] && tables[6] == tables[8])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[1] == 'X' || tables[1] == 'O' && tables[4] == 'X' || tables[4] == 'O' && tables[7] == 'X' || tables[7] == 'O')
                    {
                        if (tables[1] == tables[4] && tables[4] == tables[7] && tables[1] == tables[7])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[2] == 'X' || tables[2] == 'O' && tables[5] == 'X' || tables[5] == 'O' && tables[8] == 'X' || tables[8] == 'O')
                    {
                        if (tables[2] == tables[5] && tables[5] == tables[8] && tables[2] == tables[8])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[0] == 'X' || tables[0] == 'O' && tables[4] == 'X' || tables[4] == 'O' && tables[8] == 'X' || tables[8] == 'O')
                    {
                        if (tables[0] == tables[4] && tables[4] == tables[8] && tables[0] == tables[8])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");

                            break;
                        }
                    }
                    if (tables[2] == 'X' || tables[2] == 'O' && tables[4] == 'X' || tables[4] == 'O' && tables[6] == 'X' || tables[6] == 'O')
                    {
                        if (tables[2] == tables[4] && tables[4] == tables[6] && tables[2] == tables[6])
                        {
                            Console.WriteLine("\n" + tables[0] + " | " + tables[1] + " | " + tables[2] + "\n----------\n" +
                                                 tables[3] + " | " + tables[4] + " | " + tables[5] + "\n----------\n" +
                                                 tables[6] + " | " + tables[7] + " | " + tables[8] + "\n");
                            Console.WriteLine(firstvalue + "  won! ");
                            break;
                        }
                    }
                    for (int k = 0; k < 1; k++)
                    {
                        firstvalue = firstvalue == 'X' ? 'O' : 'X';
                    }
                } while (keldon);
                Console.WriteLine("[Please press 'y' to play again.] \n[Press Enter to return to main menu...]");
            } while (Console.ReadLine() == "y");
        }

    }
}
