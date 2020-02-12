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
                            Printinformation();
                            Console.ReadKey();
                            Menu.switching();
                            return;                            
                        case Members.Exit:
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
