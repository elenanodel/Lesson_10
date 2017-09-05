using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = Console.ReadLine();
            // printSymb(str);
            /* int a = 6;
             int b = 44;            
             Console.WriteLine("A is: " + a);
             Console.WriteLine("B is: " + b);
             swap(ref a, ref b);
             Console.WriteLine("After swap");

             Console.WriteLine("A is: " + a);
             Console.WriteLine("B is: " + b);*/

            /* string symb;
             int count;
             Console.Write("Enter symbol to repeat: ");
             symb = Console.ReadLine();
             Console.Write("Enter count of repeating: ");
             count = int.Parse(Console.ReadLine());

             print(count, symb);*/

            /*long num;
            Console.Write("Enter your number: ");
            num = long.Parse(Console.ReadLine());
            
            num = factorial(num);
            Console.Write("Factorial is: " + num);*/

            /*int n = 3;
            long res = factorial(n);*/
                        
            Console.WriteLine();
            print("J", 10, 80);
                       
            Console.ReadLine();
        }              

        static void print(string symb, int count, int border)
        {
            starsPrint(border);
            print(symb, count);            
            starsPrint(border);
        }

        static void starsPrint(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void print(string symb, int count)
        {
            for (int i = 0; i < count; i++)
            {
               print(symb);
            }
            Console.WriteLine();
        }

        static void print(string symb)
        {
            Console.Write(symb + "\t");
        }

      

       

        static long factorial(int n)
        {
            if (n == 0) return 1;
            Console.WriteLine(n);
            return n * factorial(n - 1);
        }

        static long factorial (long num)
        {
            long result = 1;
            for (int i = 1; i <= num; i++)
            {                
                result *= i;               
            }
            return result;
        }

      
       static void printSymb(string symb)
        {
            nextPrint();
            Console.WriteLine(symb);
        }

        static void nextPrint()
        {
            Console.Write("The symbol is: ");
        }

        static void swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
