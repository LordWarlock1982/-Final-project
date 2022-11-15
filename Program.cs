//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//Console.Write("Введи N: ");
//int N = Convert.ToInt16(Console.ReadLine());
//Console.Write("Введи M: ");
//int M = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine($"N={N}, M={M}");
//if (M>N)
//for (int i = N; i <= M; i++)
//    Console.Write($" {i}");
//else
//    for (int i = M; i <= N; i++)
//        Console.Write($" {i}");

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
//		int CalculateSumm(int m, int n)
//		{
//			int start = m;
//			int end = n;
//			if(m > n)
//			{
//				start = n;
//				end = m;
//			}
//			return (end + start)*(end - start + 1)/2; 
//		}
		
//		Console.WriteLine(CalculateSumm(1, 15));
//	    Console.WriteLine(CalculateSumm(4, 8));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
//using System;
 
//namespace ConsoleApp
//{
//    class Program
//    {
//        public static int Depth = 0;
//        public static UInt64 AckermannFunc(UInt64 m, UInt64 n) {
//            Depth++;
//            if (m == 0)
//                return n + 1;
//            if (n == 0)
//                return AckermannFunc(m - 1, 1);
//            return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
//        }
 
//        static void Main(string[] args) {
//            Console.WriteLine(AckermannFunc(3, 2));
//            Console.WriteLine(Depth);
//        }
//    }
//}