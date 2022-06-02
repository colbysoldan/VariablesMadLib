using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring variables

            string university, fastFoodChain, graduate; 
            int years;
            char letterGrade;
            bool didHeGraduate;
            double gpa;
            decimal hourlyWage;

            Console.WriteLine("Let's write a story together! I'm going to need your help with a few of the details though.");

            //String 1
            Console.Write("\nEnter the name of a university: ");
            university = Console.ReadLine();


            //Int
            Console.Write("Enter a whole number between 2 and 10: ");
            years = Convert.ToInt32(Console.ReadLine());

            //char
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
            do
            {
                Console.Write("Enter a number between 1.00 and 3.00: ");
                gpa = Convert.ToDouble(Console.ReadLine());
            }
            while (gpa > 3.00 || gpa < 1.00);

            

            //String 3
            Console.Write("Enter the name of a fast food chain: ");
            fastFoodChain = Console.ReadLine();

            //Decimal
            Console.Write("Enter a value between 1.00 and 100.00: ");
            hourlyWage = Convert.ToDecimal(Console.ReadLine());
            decimal yearlySalary = hourlyWage * 8 * 5 * 52;
            //Mad Libs

            //How I originally wrote it. Way messier.
            /*Console.WriteLine("\nMy brother attended " + university + " for " + years + " years.");
            Console.WriteLine("On his last report card he got straight " + letterGrade + "s.");
            Console.WriteLine("He " + graduate + " in May with a " + gpa + " GPA.");
            Console.WriteLine("Now he works at " + fastFoodChain + " making $" + hourlyWage + " per hour.");*/

            Console.WriteLine($"\nMy brother attended {university} for {years} years.");
            Console.WriteLine($"On his last report card he got straight {letterGrade}s.");
            Console.WriteLine($"He {graduate} in May with a {gpa} GPA.");
            Console.WriteLine($"Now he works at {fastFoodChain} making ${yearlySalary} per year.");

            Console.ReadLine();
        }
    }
}

