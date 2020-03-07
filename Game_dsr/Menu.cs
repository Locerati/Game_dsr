using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Game_dsr
{
   
    class Menu
    {
        public enum Members
        {
            New_game,
            Instruction,
            See_last_save_game,
            Exit
        }
        public static void switching()
        {
            Console.Clear();
            ConsoleKeyInfo key;
            Members title = Members.New_game;
            Printmenu(title);
            do
            {
                key = Console.ReadKey(true);
                
                if (key.Key == ConsoleKey.Enter)
                {
                    switch (title)
                    {
                        case Members.New_game:
                            Maingame.play();
                            break;
                        case Members.Instruction:
                            View.Printinformation();
                            Console.ReadKey();
                            Menu.switching();
                            return;
                        case Members.See_last_save_game:
                            Printg();
                            Menu.switching();
                            return;
                        case Members.Exit:
                            Data.Write();
                            return;
                            
                        default:
                            break;
                    }

                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    switch (title)
                    {
                        
                        case Members.Exit:
                            title = Members.New_game;
                            Printmenu(title);
                            break;
                        default:
                            title++;
                            Printmenu(title);
                            break;
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    switch (title)
                    {

                        case Members.New_game:
                            title = Members.Exit;
                            Printmenu(title);
                            break;
                        default:
                            title--;
                            Printmenu(title);
                            break;
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);
        }
        public static void Printmenu(Members mem)
        {
            Console.Clear();
            foreach (Members p in Enum.GetValues(typeof(Members)))
            {
                if (p == mem)
                {       Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine((Members)p);
                Console.ResetColor();
                } else
                    Console.WriteLine((Members)p);

            }
        }
        public static void Printg()
        {

            Console.Clear();
            if (Program.numbers.Count != 0)
            {
                int k = 0;
                ConsoleKeyInfo key;

                for (int i = 0; i < Program.numbers.Count; i++)
                {
                    if (i == k)
                        Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(Program.numbers[i]);
                    Console.ResetColor();
                }
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();

                        k--;
                        if (k == -1)
                        {
                            k = Program.numbers.Count - 1;
                        }
                        for (int i = 0; i < Program.numbers.Count; i++)
                        {
                            if (i == k)
                                Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(Program.numbers[i]);
                            Console.ResetColor();
                        }
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();
                        k++;
                        if (k == Program.numbers.Count)
                        {
                            k = 0;
                        }
                        for (int i = 0; i < Program.numbers.Count; i++)
                        {
                            if (i == k)
                                Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(Program.numbers[i]);
                            Console.ResetColor();
                        }
                    }
                    if (key.Key == ConsoleKey.Enter)
                    {
                        int[,,] array = new int[16, 7, 5];
                        array = Lasrgame.Readinggame(Program.numbers[k]);
                        View.Printlastgame(array);
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        return;
                    }


                    }
                while (key.Key != ConsoleKey.Enter);
            }
            else
            {
                Console.WriteLine("Нет сохраненных игр");
                Console.ReadKey(true);
                return;
            }
        }




    }
}
