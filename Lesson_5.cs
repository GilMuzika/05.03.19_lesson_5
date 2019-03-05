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
                 // st = st + " " + i;
                  Console.WriteLine(i);
                  for (int j = 0; j <= i; j++)
                  {
                     // st2 = st2 + " " + j;
                      Console.Write(j);
                  }
              }

            Console.WriteLine("\n\n-------------------------------\n-----------------\n");

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
           
            Console.WriteLine($"Our money is {money} NIS. We need {notes_200}{(notes_200 == 0 ? "" : " banknotes of 200 NIS, ")} {notes_100}{(notes_100 == 0 ? "" : " banknotes of 100 NIS, ")} {notes_50}{(notes_50 == 0 ? "" : " banknotes of 50 NIS, ")}   {notes_10}{(notes_10 == 0 ? "" : " banknotes of 10 NIS, ")}  {notes_5}{(notes_5 == 0 ? "" : " banknotes of 5 NIS, ")}  and {lessnotes_5} coins of 1 NIS");




            Console.WriteLine("\n\n-------------------------------\n-----------------\n");
            


            for (int i = 5; i > 0; i--)
            {
                for (int j = i; j > 0; j--) { Console.Write("*"); }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");





            Console.WriteLine("\n\n-------------------------------\n-----------------\n");





            int sum = 0;
            int n;
            do
            {
                n = PleaseEnterSomeNumbers(1)[0];
                sum = sum + n;
            }

            while (PrimeNumCalc( n ));

            Console.WriteLine(sum);









        }



        static bool PrimeNumCalc(int n)
        {
            int j = n - 1;
            while (j > 1)
            {
                if (n % j == 0) { return false; }
                j = j - 1;
            }
            return true;
        }

        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                //if (i > 0) { Console.Clear(); }
                if (i != 0) { Console.WriteLine("Please enter a number: \n"); }
                int line;
                EnterNumber:
                if (Int32.TryParse(Console.ReadLine(), out line)) { arriterations[i] = line; }
                else { Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); goto EnterNumber; }
                //Console.Clear();
            }

            return arriterations;
        }

    }
}
