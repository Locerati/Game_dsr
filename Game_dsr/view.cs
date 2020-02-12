using System;
using System.Collections.Generic;
using System.Text;

namespace Game_dsr
{
    class View
    {
        public static void Printarray (int[,] array,(int,int)index)
        {
            Console.Clear();
            for (int i = 0; i < array.GetLongLength(0); i++)
            { Console.WriteLine();
                for (int j = 0; j < array.GetLongLength(1); j++)
                {
                    if (i == index.Item1 && j == index.Item2)
                    {

                        if (array[i, j] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[x]" + '\t');
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("[*]" + '\t');
                            
                        }
                        Console.ResetColor();
                    }
                    else
                        switch (array[i, j])
                        {
                            case 0:
                                Console.Write("[ ]" + '\t');
                                break;
                            case 1:
                                Console.Write('\t');
                                break;
                            case 2:
                                Console.Write("[*]" + '\t');
                                break;
                            case 3:
                                Console.Write("[x]" + '\t');
                                break;
                            default:
                                break;
                        }
                }
            }


        }

       
    }
}
