using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {



            for (int i = 0; i <= 100; i++)
            {
                //if (i % 7 == 0) Console.WriteLine(i);
                Console.WriteLine(i%7==0 ? i+"" : "The number can't be divided by 7 without remains");
            }


              string st = "";
              string st2 = "";
              for (int i = 0; i <= 5; i++)
              {
                  st = st + " " + i;
                  Console.Write(st);
                  for (int j = 0; j <= 5; j++)
                  {
                      st2 = st2 + " " + j;
                      Console.WriteLine(st2);
                  }
              }

            Console.WriteLine("-------------------------------\n-----------------\n");

            int money = 1536;
            int notes_200 = money / 200;

            int lessnotes_200 = money % 200;

            int notes_100 = lessnotes_200 / 100;

            int lessnotes_100 = lessnotes_200 % 100;

            int notes_50 = lessnotes_100 / 50;

            int lessnotes_50 = lessnotes_100 % 50;

            int notes_20 = lessnotes_50 / 20;

            int lessnotes_20 = lessnotes_50 % 20;

            int notes_10 = lessnotes_50 / 10;

            int lessnotes_10 = lessnotes_50 % 10;

            int notes_5 = lessnotes_10 / 5;

            int lessnotes_5 = lessnotes_10 % 5;
           
            Console.WriteLine($"Our money is {money} NIS. We need {notes_200} banknotes of 200 NIS, {notes_100}  banknotes of 100 NIS{(notes_50==0 ? "" : ", banknotes of 50 NIS")}  , {notes_10} coins of 10 NIS, {notes_5} coins of 5 NIS and {lessnotes_5} cpins of 1 NIS");

        }





    }
}
