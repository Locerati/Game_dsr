using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
        public static void Printlastgame(int[,,] array)
        {
            Console.Clear();
            
            
           
                
                    int j = 0;
                while (j < 16 && array[j, 0, 0] != 0)
                {
                    for (int k = 0; k < array.GetLongLength(1); k++)
                    {
                        for (int i = 0; i < array.GetLongLength(2); i++)
                        {
                            switch (array[j,k,i])
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
                        Console.WriteLine();
                    }
                    j++;
                    ConsoleKeyInfo key;

                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Escape)
                        return;
                    Console.Clear();
                }
                Console.ReadKey(true);
                return;
            
        }

        public static void Printinformation()
        {
            Console.Clear();
            using (FileStream fstream = File.OpenRead("instruction.txt"))
            {
                string line;
                try
                {
                    StreamReader file = new System.IO.StreamReader("instruction.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    file.Close();
                }
                catch { }
            }


        }




    }
}
