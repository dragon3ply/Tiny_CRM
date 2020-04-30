using System;
using System.IO;
using Tiny_CRM;
using System.Collections.Generic;
using System.Linq;

namespace Tiny_Crm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allLinesText = File.ReadAllLines(@"C:\Users\drako\devel\Products.txt").ToList();

            //Console.WriteLine(allLinesText[2]);

            int SizeOfList;

            SizeOfList = allLinesText.Count;
            Console.WriteLine(SizeOfList);


            List<string> allIds = new List<string>();

            for (int i = 1; i < SizeOfList; i++)
            {
                string[] words = allLinesText[i].Split(';');
                allIds.Add(words[0]);
                //Console.WriteLine(allIds[i-1]);//i-1 xekiname apo to miden
            }


            List<string> distinct = allIds.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine("After: {0}", value);
            }


            Random rnd = new Random();
            int month = rnd.Next(1, 13);  // creates a number between 1 and 12
            int dice = rnd.Next(1, 7);   // creates a number between 1 and 6
            int card = rnd.Next(52);

            for (int i = 0; i < SizeOfList; i++)
            {
                allLinesText[i] = allLinesText[i] + ";" + rnd.Next(0, 10000).ToString();
                Console.WriteLine(allLinesText[i]);
            }

            /*public static int NextInt32(this Random rng)
            {
            unchecked
                {
                int firstBits = rng.Next(0, 1 << 4) << 28;
                int lastBits = rng.Next(0, 1 << 28);
                return firstBits | lastBits;
                }
            }
            
            public static decimal NextDecimal(this Random rng)
            {
            byte scale = (byte)rng.Next(29);
            bool sign = rng.Next(2) == 1;
            return new decimal(NextInt32(rng),
                               NextInt32(rng),
                               NextInt32(rng),
                               sign,
                               scale);
            }*/
            

        }
    }

}


