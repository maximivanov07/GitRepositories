using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberTest
    {
    class Program
        {
        static void Main(string [] args)
            {
            //Test();
            //TestSwithcing();
            //TestWh();
            //TestArr();
            TestRow();
        }
        public static void Test()
            {
            Console.WriteLine("Type A");
            string userTypeA = Console.ReadLine();
            Console.WriteLine("Type B");
            string userTypeB = Console.ReadLine();
            int aNumb = Convert.ToInt32(userTypeA);
            int bNumb = Convert.ToInt32(userTypeB);

            double c = aNumb - bNumb;

            if (c >= 10)
                {
                Console.WriteLine(c);
                }
            else
                Console.WriteLine("<10");
            Console.ReadLine();
            }
        static void TestGiving(int z)
            {
            int a = 1;
            int b = 3;
            z = a + b;
            }
        static void TestSwithcing()
            {
            Console.WriteLine("Type Operator");
            string menuChouise = Console.ReadLine();

            switch (menuChouise)
                {
                case "+":
                    Console.WriteLine("+");
                    Console.ReadLine();
                    break;
                case "-":
                    Console.WriteLine("-");
                    Console.ReadLine();
                    break;
                case "\\":
                    Console.WriteLine("\\");
                    Console.ReadLine();
                    break;
                case "*":
                    Console.WriteLine("*");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("error");
                    Console.ReadLine();
                    break;
                }
            }
        static void TestWh()
            {
            string utype = Console.ReadLine();
            int a = Convert.ToInt32(utype);

            while (a < 0 && a>10)
                {
                Console.WriteLine(a);
                }
            Console.ReadLine();
            }
        static void TestArr()
            {
            int [] array = new int [] { 3, 4, 5, -57, 3, 3, 1212, 5, 7 };
            int a = 99 + array [2];
            Console.WriteLine(a);
            Console.ReadLine();
            }
        static void TestRow()
            {
            for (int stroka = 0; stroka < 9; stroka+=2)
                {
                for (int spaces = 9; spaces > stroka; spaces-=2)
                    {
                    Console.Write(" ");
                    }
                for (int column = 0; column<=stroka ; column++)
                    {
                    Console.Write("*");
                    }
                Console.WriteLine();
                }
            Console.ReadLine();
            }
        }
    }
