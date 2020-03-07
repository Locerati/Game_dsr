using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Game_dsr
{
    class Lasrgame
    {
        
        public static DateTime Writinggame(int[,,] array)
        {
            DateTime dt = DateTime.Now;
             
            string namefile = DateTime.Now.ToString("yyyyMMddhhmmss");
            namefile += ".txt";
            
            using (StreamWriter sw = new System.IO.StreamWriter(namefile))
            {
                
                
                for (int j = 0; j < array.GetLongLength(0); j++)
                {
                    sw.WriteLine();
                    for (int k = 0; k < array.GetLongLength(1); k++)
                    {
                        for (int i = 0; i < array.GetLongLength(2); i++)
                        {
                            sw.Write(String.Format($"{array[j, k, i]} "));
                            
                        }
                        sw.WriteLine();
                    }
                }
                sw.Close();
               
            }
            return dt;
           

        }
    
                
            
        

        public static int[,,]  Readinggame(DateTime dat)
        {
            string namefile = dat.ToString("yyyyMMddhhmmss");
            namefile += ".txt";
            int[,,] array = new int [16,7,5];
            using (FileStream fstream = File.OpenRead(namefile))
            {

                string line;


                StreamReader file = new System.IO.StreamReader(namefile);
                int j = -1;
                int k = 0;
                while ((line = file.ReadLine()) != null)
                {
                    string[] tokens = line.Split();
                    if (line != "")
                    {
                        
                            
                                for (int i = 0; i < array.GetLongLength(2); i++)
                                {
                                    array[j, k, i] = int.Parse(tokens[i]);


                                }
                        k++;
                    }
                    else 
                    {
                        j++;
                        k = 0;
                    }

                    
                }
                file.Close();
            }
            return array;
        }
    }
}
