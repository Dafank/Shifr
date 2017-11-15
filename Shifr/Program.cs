using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифрування
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int i = 2, j = 2;
            int n = s.Length;//половина довжини строки
            int l = n / 2;//1 половина півстроки 
            int f = l / 2;//2 половина півстроки
            char[,] mas;//массив

            if (s.Length == 13 | s.Length == 15 | s.Length == 17/*відбір чисел*/
                | s.Length == 19 | s.Length == 21 | s.Length == 23
                | s.Length == 25 | s.Length == 27 | s.Length == 29
                | s.Length == 31 | s.Length == 33 | s.Length == 35
                | s.Length == 37 | s.Length == 39 | s.Length == 41
                | s.Length == 43 | s.Length == 45 | s.Length == 47
                | s.Length == 49 | s.Length == 51 | s.Length == 53
                | s.Length == 55 | s.Length == 57 | s.Length == 59
                | s.Length == 61 | s.Length == 63 | s.Length == 65
                | s.Length == 67 | s.Length == 69 | s.Length == 71
                | s.Length == 73 | s.Length == 75 | s.Length == 77
                | s.Length == 79 | s.Length == 81 | s.Length == 83
                | s.Length == 85 | s.Length == 87 | s.Length == 89
                | s.Length == 91 | s.Length == 93 | s.Length == 95
                | s.Length == 97 | s.Length == 99)
            {
                int all = n;
                n++;//збільшення для вирівнюванння числа

                for (j = f; j <= l; j++)
                {
                    if (n % j == 0)
                    {
                        break;
                    }
                }
                for (i = f; i >= 2; i--)
                {
                    if (j * i == n)
                    {
                        break;
                    }
                }
                mas = new char[i, j];

                for (int e = 0, t = 0; e < i; e++)
                {
                    for (int r = 0; r < j; r++)
                    {
                        if (t <= s.Length)
                            mas[e, r] = s[t++];
                    }
                }
                for (int e = 0; e < j; e++)
                {
                    for (int r = 0; r < i; r++)
                    {
                        if ((mas[r, e]) == ' ')
                        {
                            mas[r, e] = '_';
                            Console.Write(mas[r, e]);
                        }
                        else
                        {
                            Console.Write(mas[r, e]);
                        }
                    }
                }

                Console.WriteLine("\n" + n);
                Console.WriteLine("{0}: {1}: ", i, j);
            }
            else if (s.Length == 14 | s.Length == 16 | s.Length == 18 |
                s.Length == 20 | s.Length == 21 | s.Length == 22 | s.Length == 24
                | s.Length == 26 | s.Length == 27 | s.Length == 28 | s.Length == 30
                | s.Length == 32 | s.Length == 33 | s.Length == 34 | s.Length == 36
                | s.Length == 38 | s.Length == 39 | s.Length == 40 | s.Length == 42
                | s.Length == 44 | s.Length == 45 | s.Length == 46 | s.Length == 48
                | s.Length == 50 | s.Length == 51 | s.Length == 52 | s.Length == 54
                | s.Length == 56 | s.Length == 57 | s.Length == 58 | s.Length == 60
                | s.Length == 62 | s.Length == 63 | s.Length == 64 | s.Length == 66
                | s.Length == 68 | s.Length == 69 | s.Length == 70 | s.Length == 72
                | s.Length == 74 | s.Length == 75 | s.Length == 76 | s.Length == 78
                | s.Length == 80 | s.Length == 81 | s.Length == 82 | s.Length == 84
                | s.Length == 86 | s.Length == 87 | s.Length == 88 | s.Length == 90
                | s.Length == 92 | s.Length == 93 | s.Length == 94 | s.Length == 96
                | s.Length == 98 | s.Length == 99)
            {
                for (j = f; j <= l; j++)
                {
                    if (n % j == 0)
                    {
                        break;
                    }
                }
                for (i = f; i >= 2; i--)
                {
                    if (j * i == n)
                    {
                        break;
                    }
                }
                mas = new char[i, j];

                for (int e = 0, t = 0; e < i; e++)
                {
                    for (int r = 0; r < j; r++)
                    {
                        if (t <= s.Length)
                            mas[e, r] = s[t++];
                    }
                }
                for (int e = 0; e < j; e++)
                {
                    for (int r = 0; r < i; r++)
                    {
                        if ((mas[r, e]) == ' ')
                        {
                            mas[r, e] = '_';
                            Console.Write(mas[r, e] + " ");
                        }
                        else
                        {
                            Console.Write(mas[r, e] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n" + n);
                Console.WriteLine("{0}: {1}: ", j, i);
            }
            else if (s.Length == 4 | s.Length == 6 | s.Length == 8 | s.Length == 9
                | s.Length == 10 | s.Length == 12)
            {

                for (j = 2; j <= l; j++)
                {
                    if (n % j == 0)
                    {
                        break;
                    }
                }
                for (i = l; i >= 2; i--)
                {
                    if (j * i == n)
                    {
                        break;
                    }
                }
                mas = new char[i, j];

                for (int e = 0, t = 0; e < i; e++)
                {
                    for (int r = 0; r < j; r++)
                    {
                        if (t < s.Length)
                            mas[e, r] = s[t++];
                    }
                }
                for (int e = 0; e < j; e++)
                {
                    for (int r = 0; r < i; r++)
                    {
                        if ((mas[r, e]) == ' ')
                        {
                            mas[r, e] = '_';
                            Console.Write(mas[r, e] + " ");
                        }
                        else
                        {
                            Console.Write(mas[r, e] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n" + n);
                Console.WriteLine("{0}: {1}: ", j, i);

            }
            else
            {
                n++;
                for (j = 2; j <= l; j++)
                {
                    if (n % j == 0)
                    {

                    }
                }
                for (i = l; i >= 2; i--)
                {
                    if (j * i == n)
                    {
                        break;
                    }
                }
                mas = new char[i, j];

                for (int e = 0, t = 0; e < i; e++)
                {
                    for (int r = 0; r < j; r++)
                    {
                        if (t < s.Length)
                            mas[e, r] = s[t++];
                    }
                }
                for (int e = 0; e < j; e++)
                {
                    for (int r = 0; r < i; r++)
                    {
                        if ((mas[r, e]) == ' ')
                        {
                            mas[r, e] = '_';
                            Console.Write(mas[r, e] + " ");
                        }
                        else
                        {
                            Console.Write(mas[r, e] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n" + n);
                Console.WriteLine("{0}: {1}: ", j, i);
            }
            Console.ReadKey();
        }
    }
}

