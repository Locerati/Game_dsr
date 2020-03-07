using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Game_dsr
{
    class Data
    {
        public static void Read()
        {
            using (FileStream fstream = File.OpenRead("t.txt"))
            {

                string line;


                StreamReader file = new System.IO.StreamReader("t.txt");
                while ((line = file.ReadLine()) != null)
                {
                    try
                    {
                        Program.numbers.Add(DateTime.Parse(line));
                    }
                    catch 
                    {
                    }
                }
                file.Close();
            }
        }
        public static void Write()
        {
            
            using (StreamWriter sw = new System.IO.StreamWriter("t.txt", false))
            {
                for (int i = 0; i < Program.numbers.Count; i++)
                {
                    sw.WriteLine(Program.numbers[i].ToString());

                }
            }
        }

    }
}