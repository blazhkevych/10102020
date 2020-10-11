using System;
using System.Text;
using System.Linq;

namespace CoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Hello it Step");
            Console.WriteLine("Вітаємо в Акадмії ШАГ");

            // Console.Write("a=");
            //double a = double.Parse(Console.ReadLine());
            // bool f = double.TryParse(Console.ReadLine(), out double a);

            //    Console.WriteLine("Format error A");
            int k = 123;
            // Console.WriteLine($"k=|{k,-10:d8}|");

            string n = "123323";
            int h1 = n.Take(3).Select(x => (int)x).Sum();
            int h2 = n.TakeLast(3).Select(x => (int)x).Sum();

            if (h1 == h2)
                Console.WriteLine("Щасливий");
            else
                Console.WriteLine("Not Щасливий");
            Console.WriteLine(h1 == h2 ? String.Empty : "Not " + "Щасливий");

            //&& || 
            // h1 = 50;
            //var p=(h1 > 10 || h2 > 30);
            // 1// 10    20  30 
            // 2// 10    30  20
            // 3// 20    10  30
            // 4// 30    10  20
            // 5// 20    30  10
            // 6// 30    20  10
            // 7// 10    10  20
            // 8// 20    10  10
            // 9// 10    10  10
            //10// 10    10  5
            int a = 20;
            int b = 10;
            int c = 30;

            if (a > b)
            {
                if (a > c)
                    Console.WriteLine($"Max={a}");
                else
                    Console.WriteLine($"Max={c}");
            }
            else
            {
                if (b > c)
                    Console.WriteLine($"Max={b}");
                else
                    Console.WriteLine($"Max={c}");
            }
            //----------------------------
            if (a >= b && a >= c)
                Console.WriteLine($"Max={a}");
            else
            {
                if (b >= c)
                    Console.WriteLine($"Max={b}");
                else
                    Console.WriteLine($"Max={c}");
            }
            //------------------
            int max;
            if (a > b)
                max = a;
            else
                max = b;
            if (c > max)
                max = c;
            Console.WriteLine($"Max={max}");
            Console.WriteLine($"Max={Math.Max(Math.Max(a, b), c)}");
            Console.WriteLine($"Max={Math.Max(a > b ? a : b, c)}");

            //a = 3;
            //b = 1024;
            //string r = "GB";
            //long rez = 1;
            //switch (r)
            //{
            //    case "GB": 
            //        rez*=1024;
            //        goto case "MB";
            //    case "MB":
            //        rez *= 1024;
            //        goto case "KB";
            //    case "KB":
            //        rez *= 1024;
            //        goto case  "B";
            //    case "B":
            //        rez *= b;
            //        Console.WriteLine($"{rez}");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;

            //}
            Console.WriteLine($"----------------------------");

            int N = 10;
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{i} {rnd.Next(-10, 10)}");
                Console.WriteLine($"{i} {rnd.NextDouble()}");
                continue;
                break;
            }
            Console.WriteLine($"----------------------------");
            int jj = 0;
            while (jj < N)
            {
                Console.WriteLine($"{jj} {rnd.Next(-10, 10)}");
                jj++;
                continue;
            }

            //lab:
            Console.WriteLine($"----------------------------");
            jj = 10;
            do
            {
                Console.WriteLine($"{jj} {rnd.Next(-10, 10)}");
                jj++;
            } while (jj < N);
            // goto lab;

            int? pp = null;
            Nullable<int> kk = null;

            //if (pp == null)
            //    pp = 10;

            a = pp ?? 30;
            // pp = pp ?? 30;
            // pp ??= 30;
            Console.WriteLine($"pp={pp}");
            Console.WriteLine($"a={a}");



            //int[] mas= { };
            //int[] mas = new int[10];
            // int[] mas = new int[4] {10,20,30,63 };
            // int[] mas = new int[] {10,20,30,63 };
            //int[] mas = new[] {10,20,30,63 };
            // int[] mas =  {10,20,30,63 };
            int[] mas = null;
            // mas[0] = 10;
            mas = new[] { 10, 20, 30, 63, 7898 };
            foreach (var number in mas)
                Console.Write($"{number}\t");
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
                Console.Write($"{mas[i]}\t");

            Console.WriteLine($"\n----------------------------");
            // int[,] arr2d = { };
            const int row = 2, col = 3;
            //int[,] arr2d = new int[row, col] { { 1, 2, 3 },{ 4, 5, 6 } };
            //int[,] arr2d = new int[, ] { { 1, 2, 3 },{ 4, 5, 6 } };
            // int[,] arr2d = new [, ] { { 1, 2, 3 },{ 4, 5, 6 } };
            int[,] arr2d = { { 1, 2, 3 }, { 4, 5, 6 } };


            foreach (var number in arr2d)
                Console.Write($"{number}\t");
            Console.WriteLine();
            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                    Console.Write($"{arr2d[i, j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine(arr2d.GetUpperBound(1));


            //int[][] jmas = new int[3][];
            //jmas[0] = new[] { 1, 2, 3, 4, 5 };
            //jmas[1] = new[] { 6, 7, 8, 9 };
            //jmas[2] = new[] { 1, 0, 2 };

            //int[][] jmas = new int[][] {
            //                      new[] { 1, 2, 3, 4, 5 },
            //                      new[] { 6, 7, 8, 9 },
            //                      new[] { 1, 0, 2 },
            //                    };

            int[][] jmas =  {
                                  new[] { 1, 2, 3, 4, 5 },
                                  new[] { 6, 7, 8, 9 },
                                  new[] { 1, 0, 2 },
                                };

            foreach (var mmas in jmas)
            {
                foreach (var number in mmas)
                    Console.Write($"{number}\t");
                Console.WriteLine();
            }
            Console.WriteLine($"\n----------------------------");
            mas = new[] { 10, 20, 30, 40 };
            int[] mascopy = (int[])mas.Clone();




            mas[1] = 555;

            foreach (var number in mas)
                Console.Write($"{number}\t");
            Console.WriteLine();
            foreach (var number in mascopy)
                Console.Write($"{number}\t");
            Console.WriteLine();

            Array.Reverse(mascopy);
            foreach (var number in mascopy)
                Console.Write($"{number}\t");
            Console.ReadKey();
        }
    }
}
