using System;
using System.Collections.Generic;
using System.Text;

namespace Game_dsr
{
    static class Init
    {
        public static void Initialization(int[,] array)
        {
            for (int i = 0; i < array.GetLongLength(0); i++)
                for (int j = 0; j < array.GetLongLength(1); j++)
                    array[i, j] = 0;

            for (int i = 0; i < array.GetLongLength(0); i++)
            {
                int j = 0;
                array[i, j] = 1;
                j = (int)array.GetLongLength(1) - 1;
                array[i, j] = 1;

            }

            for (int j = 0; j < array.GetLongLength(1); j++)
            {
                int i = 0;
                array[i, j] = 1;
                i = (int)array.GetLongLength(0) - 1;
                array[i, j] = 1;

            }

            array[3, 2] = 2;
            array[4, 1] = 3;
            array[5, 2] = 3;
            array[4, 3] = 3;
            array[1, 1] = 1;
            array[1, 3] = 1;
            array[5, 1] = 1;
            array[5, 3] = 1;
        }
        public static void Initialization2((int, int)[] index1, out (int, int) index2)
        {

            index1[0].Item1 = 4;
            index1[0].Item2 = 1;
            index1[1].Item1 = 5;
            index1[1].Item2 = 2;
            index1[2].Item1 = 4;
            index1[2].Item2 = 3;

            index2.Item1 = 3;
            index2.Item2 = 2;
        }

    }
}
