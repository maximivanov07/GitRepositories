using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
    {
    public enum DaysOfWeek { Sunday = 7, Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6 };
    public enum MonthOfYear { January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, Septemper = 9, October = 10, November = 11, December = 12 }


    namespace RememberTest
        {
        class Program
            {
            static void Main(string [] args)
                {

                //Switching and user type

                //Test();
                //TestSwithcing();

                //Loops

                //TestWh();
                //TestRow();
                //FizzBuzz();

                //Arrays
                //TestArrCopy();
                //MultArray();

                //Enums
                //enumCollTest();

                //Methods
                //GetNumberFromUser(); useful return
                //CalculatePlayerScore();
                //CountToTen(); //sending stuff to Method

                entUsersNumber(toSend);
               

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

                while (a < 0 && a > 10)
                    {
                    Console.WriteLine(a);
                    }
                Console.ReadLine();
                }
            static void TestArrCopy()
                {
                int [] arrayOrigin = new int [10] { 3, 4, 5, -57, 3, 3, 1212, 5, 7, 3 };
                int [] arrayClone = new int [arrayOrigin.Length];

                for (int index = 0; index < arrayOrigin.Length; index++)
                    {
                    int a = arrayOrigin [index];
                    Console.WriteLine("Original: {0}", a);

                    int b = a + arrayClone [index];
                    Console.WriteLine("Clone: {0}", b);
                    }
                Console.ReadLine();
                }
            static void TestRow()
                {
                for (int stroka = 0; stroka < 9; stroka += 2)
                    {
                    for (int spaces = 9; spaces > stroka; spaces -= 2)
                        {
                        Console.Write(" ");
                        }
                    for (int column = 0; column <= stroka; column++)
                        {
                        Console.Write("*");
                        }
                    Console.WriteLine();
                    }
                Console.ReadLine();
                }
            static void FizzBuzz()
                {
                for (int i = 1; i <= 100; i++)
                    {
                    int fizz = i % 3;
                    int buzz = i % 5;

                    if (fizz == 0 && buzz == 0)
                        {
                        Console.WriteLine("FizzBuzz");
                        }
                    else if (fizz == 0)
                        {
                        Console.WriteLine("Fizz");
                        }
                    else if (buzz == 0)
                        {
                        Console.WriteLine("Buzz");
                        }
                    else
                        Console.WriteLine(i);
                    }
                Console.ReadLine();
                }
            static void MultArray()
                {
                int [,] matrix = new int [4, 4];
                // Fill in contents for multi-dimensional array 

                for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                        {
                        Console.Write(matrix [row, column] + " ");
                        }
                    Console.WriteLine();
                    }

                int [] arr = new int [4];
                arr [0] = 2;
                arr [1] = 87;
                arr [2] = 75;
                arr [3] = 6;

                foreach (int a in arr)
                    {
                    Console.Write(a);
                    }
                Console.ReadLine();
                }
            static void enumCollTest()
                {

                //DayOfWeek today;
                //today = DayOfWeek.Thursday;

                ///Console.WriteLine(today);

                //int dayAsInt = (int) DayOfWeek.Sunday;
                //DayOfWeek today = (DayOfWeek) dayAsInt;

                //Console.WriteLine(dayAsInt);

                Console.WriteLine("Type number between 1 and 12");

                string usersInput = Console.ReadLine();
                int number = Convert.ToInt32(usersInput);

                if (number == (int) MonthOfYear.January)
                    {
                    Console.WriteLine(MonthOfYear.January);
                    }
                else if (number == (int) MonthOfYear.February)
                    {
                    Console.WriteLine(MonthOfYear.February);
                    }
                else if (number == (int) MonthOfYear.March)
                    {
                    Console.WriteLine(MonthOfYear.March);
                    }
                else if (number == (int) MonthOfYear.April)
                    {
                    Console.WriteLine(MonthOfYear.April);
                    }
                else if (number == (int) MonthOfYear.May)
                    {
                    Console.WriteLine(MonthOfYear.May);
                    }
                else if (number == (int) MonthOfYear.June)
                    {
                    Console.WriteLine(MonthOfYear.June);
                    }
                else if (number == (int) MonthOfYear.July)
                    {
                    Console.WriteLine(MonthOfYear.July);
                    }
                else if (number == (int) MonthOfYear.August)
                    {
                    Console.WriteLine(MonthOfYear.August);
                    }
                else if (number == (int) MonthOfYear.Septemper)
                    {
                    Console.WriteLine(MonthOfYear.Septemper);
                    }
                else if (number == (int) MonthOfYear.October)
                    {
                    Console.WriteLine(MonthOfYear.October);
                    }
                else if (number == (int) MonthOfYear.November)
                    {
                    Console.WriteLine(MonthOfYear.November);
                    }
                else if (number == (int) MonthOfYear.December)
                    {
                    Console.WriteLine(MonthOfYear.December);
                    }
                else
                    Console.WriteLine("Wrong! You must type number between 1 to 12!");
                Console.ReadLine();
                }
            static int GetNumberFromUser()
                {
                int usersNumber = 0;
                while (usersNumber < 1 || usersNumber > 10)
                    {
                    Console.Write("Enter a number between 1 and 10: ");
                    string userResponse = Console.ReadLine();
                    usersNumber = Convert.ToInt32(userResponse);
                    }
                return usersNumber;
                }
            static int CalculatePlayerScore()
                {

                    int livesLeft = 3;
                    int underlingsDestroyed = 17;
                    int minionsDestroyed = 4;
                    int bossesDestroyed = 1;

                //If the player is out of leves, they lose all of theri points
                if (livesLeft == 0)
                    return 0;
                //otherwise, the player gets 10 points for every underling destroyed, 100 points
                //for every ninion destroyed, and 1000 points for every boss destroyed.
                return underlingsDestroyed * 10 +
                       minionsDestroyed * 100 +
                       bossesDestroyed * 1000;

                }
            ///
            
            //static void counttoten()
            //    {
            //    for (int index = 0; index <= 10; index++)
            //        {
            //        console.writeline(index);
            //        }
            //    console.readline();
            //    }

            static int entUsersNumber()
                {

                string b = Console.ReadLine();
                int toSends = Convert.ToInt32(b);
           
                return toSends;
                }

            static void Count(int toSends)
                {
                for (int current = 1; current <= toSends; current++)
                    {
                    Console.WriteLine(current);
                    }
                }
            ///
            }
        }
    }
