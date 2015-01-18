using System;

namespace _ComparingFloats

    //Problem 13.* Comparing Floats
    //Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001
    //Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the 
    //floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a real number to comepare: ");
            double a = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Write second real number to compare: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            bool check = Math.Abs(a - b) < 0.000001;
            Console.WriteLine("Are the numbers equal: " + check);
         }
    }
}
