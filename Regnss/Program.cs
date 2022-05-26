using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Regnss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] regnVejrStat = new double[7];


            for (int i = 0; i < regnVejrStat.Length; i++)
            {
                double uInput = input();
                regnVejrStat[i] = uInput;

            }

            double avgV = Queryable.Average(regnVejrStat.AsQueryable());
            double maxV = Queryable.Max(regnVejrStat.AsQueryable());
            double minV = Queryable.Min(regnVejrStat.AsQueryable());


            Console.WriteLine("Menu");
            Console.WriteLine("1: alle værdier");
            Console.WriteLine("2: max værdi");
            Console.WriteLine("3: gennemsnit");
            Console.WriteLine("4: min værdi");
            Console.WriteLine("5: exit");

            bool exit = true;
            while (exit)
            {

            
            bool a = int.TryParse(Console.ReadLine(), out int sUserIn);
            if (!a)
            {
                Console.WriteLine("Indtast et nummer som er i menuen");
                
            }

            switch (sUserIn)
            {
                case 1:
                    for (int i = 0; i < regnVejrStat.Length; i++)
                    {
                        Console.WriteLine($"Måleværdi{i + 1}: " + regnVejrStat[i] + " mm");
                    }

                    break;
                    case 2:
                        Console.WriteLine(maxV + " mm");
                        break;
                case 3:

                        Console.WriteLine(avgV + " mm");
                        break;

                    case 4:
                        Console.WriteLine(minV + " mm");
                        
                        break;

                    case 5:
                        Console.WriteLine("Tak fordi du brugte Regnvejrs statistik");
                        exit = false;
                        break;

                default:
                    break;
            }


          



        }
        }


        static double input()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("fejl \n Indtast tal:");
                Thread.Sleep(1200);
                Console.Clear();
            }
            return value;
        }

        static void output()
        {

        }
    }
}
