using System;
using System.Collections.Generic;
using System.Text;

namespace Game_dsr
{
    static class Traffic
    {
        public static bool movementfirst(int[,] array, (int, int)[] index1)
        {
            if (array[index1[0].Item1 - 1, index1[0].Item2] == 0 || array[index1[1].Item1 - 1, index1[1].Item2] == 0 || array[index1[2].Item1 - 1, index1[2].Item2] == 0)
            {
                int localindex = 0;
                ConsoleKeyInfo key;
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        localindex =localindex==0?0:localindex-1;
                        View.Printarray(array,index1[localindex]);

                    }
                    if (key.Key == ConsoleKey.RightArrow)
                    {
                        localindex = localindex == 2 ? 2 : localindex +1;
                        View.Printarray(array, index1[localindex]);
                    }
                    if ((key.Key == ConsoleKey.UpArrow) && (array[index1[localindex].Item1 - 1, index1[localindex].Item2] == 0))
                    {

                        array[index1[localindex].Item1, index1[localindex].Item2] = 0;
                        array[index1[localindex].Item1 - 1, index1[localindex].Item2] = 3;
                        index1[localindex].Item1 --;
                        View.Printarray(array, index1[localindex]);

                    }
                    else
                    {
                        key = new ConsoleKeyInfo();
                        
                    }
                }
                while (key.Key != ConsoleKey.UpArrow);
                return true;
            }
            else
                return false;

        }
        public static bool movementsecond(int[,] array,ref (int,int)index)
        {
            if (index.Item1 == 1 && index.Item2 == 2)
            {
                if (array[2, 1] == 0 || array[2, 2] == 0 || array[2, 3] == 0)
                {
                    ConsoleKeyInfo key;
                    do
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            if (array[2, 1] == 0)
                            {

                                array[1, 2] = 0;
                                array[2, 1] = 2;
                                index.Item1 = 2;
                                index.Item2 = 1;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            if (array[2, 2] == 0)
                            {

                                array[1, 2] = 0;
                                array[2, 2] = 2;
                                index.Item1 = 2;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            if (array[2, 3] == 0)
                            {

                                array[1, 2] = 0;
                                array[2, 3] = 2;
                                index.Item1 = 2;
                                index.Item2 = 3;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }


                    }
                    while (key.Key != ConsoleKey.DownArrow && key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow);
                    return true;
                }
                else return false;
            }
            else
            {
                if (array[index.Item1-1,index.Item2]==0 || array[index.Item1+1, index.Item2] == 0 || array[index.Item1, index.Item2+1] == 0 || array[index.Item1, index.Item2-1] == 0)
                {
                    ConsoleKeyInfo key;
                    do
                    {
                        key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            if (array[index.Item1,index.Item2-1 ] == 0)
                            {

                                array[index.Item1, index.Item2] = 0;
                                array[index.Item1, index.Item2 - 1] = 2;
                                index.Item2 --;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                        if (key.Key == ConsoleKey.DownArrow)
                        {
                            if (array[index.Item1+1, index.Item2 ] == 0)
                            {

                                array[index.Item1, index.Item2] = 0;
                                array[index.Item1+1, index.Item2] = 2;
                                index.Item1++;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            if (array[index.Item1, index.Item2 + 1] == 0)
                            {

                                array[index.Item1, index.Item2] = 0;
                                array[index.Item1, index.Item2 + 1] = 2;
                                index.Item2++;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                        if (key.Key == ConsoleKey.UpArrow)
                        {
                            if (array[index.Item1 - 1, index.Item2] == 0)
                            {

                                array[index.Item1, index.Item2] = 0;
                                array[index.Item1 - 1, index.Item2] = 2;
                                index.Item1--;
                                View.Printarray(array, index);
                            }
                            else
                            {
                                key = new ConsoleKeyInfo();

                            }

                        }
                    }
                    while (key.Key != ConsoleKey.DownArrow && key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.LeftArrow && key.Key != ConsoleKey.UpArrow);
                    return true;
                }
                else
                    return false;
            }
            
            
        }
    }
}
