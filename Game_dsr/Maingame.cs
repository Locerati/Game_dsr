using System;
using System.Collections.Generic;
using System.Text;

namespace Game_dsr
{
    class Maingame
    {
        public static void play()
        {
            int[,] array = new int[7, 5];
            (int, int)[] index1 = new (int, int)[3];
            (int, int) index2;
            Init.Initialization(array);
            Init.Initialization2(index1, out index2);
            View.Printarray(array, (4, 1));
            bool roadexists1 = true;
            bool roadexists2 = true;
            int j = 0;
            int[,,] savearray = new int[16, 7, 5];
            do
            {
                View.Printarray(array, index1[0]);
                roadexists1 = Traffic.movementfirst(array, index1);
                for (int k = 0; k < savearray.GetLongLength(1); k++)
                {
                    for (int i = 0; i < savearray.GetLongLength(2); i++)
                    {
                        savearray[j, k, i]=array[k,i];

                    }
                    
                }
                j++;
                if ((index2.Item1 > index1[0].Item1 && index2.Item1 > index1[1].Item1 && index2.Item1 > index1[2].Item1)||roadexists1==false)
                {
                    roadexists1 = false;
                    continue;
                }

                View.Printarray(array, index2);
                roadexists2 = Traffic.movementsecond(array, ref index2);
                for (int k = 0; k < savearray.GetLongLength(1); k++)
                {
                    for (int i = 0; i < savearray.GetLongLength(2); i++)
                    {
                        savearray[j, k, i] = array[k, i];

                    }

                }
                j++;
                if (index2.Item1 > index1[0].Item1 && index2.Item1 > index1[1].Item1 && index2.Item1 > index1[2].Item1)
                    roadexists1 = false;
            }
            while (roadexists1 && roadexists2);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (roadexists2 == true)
            {
                Console.WriteLine("ПОБЕДИЛ ВТОРОЙ ИГРОК");
            }
            else
            {
                Console.WriteLine("ПОБЕДИЛ ПЕРВЫЙ ИГРОК");
            }
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Do you want save game? Press Y if yes or press N if not");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Y)
                {
                    Program.numbers.Add(Lasrgame.Writinggame(savearray));
                    break;
                }
            } while (key.Key != ConsoleKey.N);
                Menu.switching();

        }

    }
}
