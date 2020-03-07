using System;
using System.Collections.Generic;
namespace Game_dsr
{
    class Program
    {
        public static List<DateTime> numbers = new List<DateTime>();
        static void Main(string[] args)
        {
            Data.Read();
           Menu.switching();
            
        }
    }
}
