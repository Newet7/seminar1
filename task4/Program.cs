//using System;
using System.Collections.Generic;
using System.Linq;
 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Write number 1: ");
//        int n = int.Parse(Console.ReadLine());
// //       Console.Write("Write number 2: ");
//        int m = int.Parse(Console.ReadLine());
//        for (int i = n; i <= m; i++)
//        {
//            if (i % 2 == 0) 
//            {
//                Console.Write(i + " ");
//            }
//        }
//        Console.ReadKey();
// //   }
//}


int a;


string input1;

input1 = Console.ReadLine();

a = Int32.Parse(input1);

//while (i < a)
//{
//    i += 2;
//    Console.Write(i);
//}

for ( int i = 1;  i <= a; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }

