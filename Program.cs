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

            int SizeOfList;

            SizeOfList = allLinesText.Count;
            Console.WriteLine(SizeOfList);


            List<string> allIds = new List<string>();

            for (int i = 1; i < SizeOfList; i++)
            {
                string[] words = allLinesText[i].Split(';');
                allIds.Add(words[0]);
               
            }


            List<string> distinct = allIds.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine("After: {0}", value);
            }


           
            for (int i = 0; i < SizeOfList; i++)
            {
                allLinesText[i] = allLinesText[i] + ";" + GetRandomPrice().ToString();
                Console.WriteLine(allLinesText[i]);
            }

        }
        public static decimal GetRandomPrice()
        {
            var random = new Random();
            var randomNumber = random.NextDouble() * 100;
            var roundedNumber = Math.Round(randomNumber, 2);

            return (decimal)roundedNumber;
        }

    }

}
