using System;

namespace FinalGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What score out of 100 do you expect to receive in ISM 4300? Enter an integer value.");
            string grade;
            grade = Console.ReadLine();

            int n = Int32.Parse(grade);
            if (n < 60)
            {
                Console.WriteLine("F");
            }
            else if (n >= 60 && n <= 61)
            {
                Console.WriteLine("D-");
            }
            else if (n >= 62 && n <= 67)
            {
                Console.WriteLine("D");
            }
            else if (n >= 68 && n <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (n >= 70 && n <= 71)
            {
                Console.WriteLine("C-");
            }
            else if (n >= 72 && n <= 77)
            {
                Console.WriteLine("C");
            }
            else if (n >= 78 && n <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (n >= 80 && n <= 81)
            {
                Console.WriteLine("B-");
            }
            else if (n >= 82 && n <= 87)
            {
                Console.WriteLine("B");
            }
            else if (n >= 88 && n <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (n >= 90 && n <= 91)
            {
                Console.WriteLine("A-");
            }
            else if (n >= 92 && n <= 97)
            {
                Console.WriteLine("A");
            }
            else if (n >= 98 && n <= 100)
            {
                Console.WriteLine("A+");
            }
        }
    }
}
