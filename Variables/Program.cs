using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string university, fastFoodChain, graduate; //added string graduate
            int years;
            char letterGrade;
            bool didHeGraduate;
            double gpa;
            decimal hourlyWage;

            //String 1
            Console.Write("Enter the name of a university: ");
            university = Console.ReadLine();


            //Int
            Console.Write("Enter a whole number between 2 and 10: ");
            years = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a letter grade (A, B, C, D, or F): ");
            letterGrade = Convert.ToChar(Console.ReadLine());

            //Boolean & String 2
            Console.Write("Enter true or false: ");

            didHeGraduate = Convert.ToBoolean(Console.ReadLine());

            if (didHeGraduate == true)
            {
                graduate = "graduated";
            }
            else
            {
                 graduate = "dropped out";
            }

            
            //Double 
            Console.Write("Enter a number between 1.00 and 3.00: ");
            gpa = Convert.ToDouble(Console.ReadLine());

            //String 3
            Console.Write("Enter the name of a fast food chain: ");
            fastFoodChain = Console.ReadLine();

            //Decimal
            Console.Write("Enter a value between 1.00 and 100.00: ");
            hourlyWage = Convert.ToDecimal(Console.ReadLine());


            //Mad Libs
            Console.WriteLine("\nMy brother attended " + university + " for " + years + " years.");
            Console.WriteLine("On his last report card he got straight " + letterGrade + "s.");
            Console.WriteLine("He " + graduate + " in May with a " + gpa + " GPA.");
            Console.WriteLine("Now he works at " + fastFoodChain + " making $" + hourlyWage + " per hour.");

            Console.ReadLine();
        }
    }
}

