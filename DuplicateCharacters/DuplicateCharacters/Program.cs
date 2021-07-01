using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write("Please enter the string : ");
            string message = Console.ReadLine();// "abbbdmmc";
            Dictionary<char, int> diction = new Dictionary<char, int>();
            foreach (char ch in message.Replace(" ", string.Empty))
            {
                if (diction.ContainsKey(ch))
                {
                    diction[ch] = diction[ch] + 1;
                }
                else
                {
                    diction.Add(ch, 1);
                }
            }

           
            int numcheck=0;
            foreach (var item in diction.OrderByDescending(k=>k.Value).Distinct())
            {
                
                Console.WriteLine(item.Key + " : " + item.Value);
                numcheck = item.Value;
            }
            Console.ReadKey();


            /*  string str = "abbbdmmc";
             Console.WriteLine("String: " + str);
             while (str.Length > 0)
             {
                 Console.Write(str[0] + " : ");
                 int count = 0;
                 for (int j = 0; j < str.Length; j++)
                 {
                     if (str[0] == str[j])
                     {
                         count++;
                     }
                 }
                 Console.WriteLine(count);
                 str = str.Replace(str[0].ToString(), string.Empty);
             }*/


            /* Console.WriteLine("Hello World!");
             var cc = DuplicateCount("abbbdmmc");
             Console.WriteLine(cc);*/
        }



       

    }
}
