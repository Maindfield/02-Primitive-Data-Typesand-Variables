using System;

namespace DeclareVariables

         //Homework: Primitive Data Types and Variables
         //Problem 1. Declare Variables
         //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
         //short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
         //Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

{
    class DeclareVariables
    {
        static void Main()
        {
            byte firstNumber = 97; 
            sbyte secondNumber = -115;
            short thirdNumber = -10000;
            int fourthNumber  = 52130;
            ulong fifthNumber = 4825932;

            Console.WriteLine("byte is = {0}\n sbyte is = {1}\n short is = {2}\n int is = {3}\n ulong is = {4}\n",
                               firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
    }
}
